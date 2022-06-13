param($installPath, $toolsPath, $package, $project)
# This install script is based on the Newtonsoft.Json NuGet install script and is licensed under the MIT License.

# The MIT License (MIT)
#
# Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
# and associated documentation files (the "Software"), to deal in the Software without restriction, 
# including without limitation the rights to use, copy, modify, merge, publish, distribute, 
# sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
# furnished to do so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
# BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
# IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
# IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


# open AWSSDK splash page on package install
# don't open if AWSSDK is installed as a dependency

try
{
  $url = "http://aws-nuget-landingpages.s3-website-us-east-1.amazonaws.com/awssdk.version.3.html?package=" + $package
  $dte2 = Get-Interface $dte ([EnvDTE80.DTE2])

  if ($dte2.ActiveWindow.Caption -eq "Package Manager Console")
  {
    # user is installing from VS NuGet console
    # get reference to the window, the console host and the input history
    # show webpage if "install-package AWSSDK" was last input

    $consoleWindow = $(Get-VSComponentModel).GetService([NuGetConsole.IPowerConsoleWindow])

    $props = $consoleWindow.GetType().GetProperties([System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    $prop = $props | ? { $_.Name -eq "ActiveHostInfo" } | select -first 1
    if ($prop -eq $null) { return }
  
    $hostInfo = $prop.GetValue($consoleWindow)
    if ($hostInfo -eq $null) { return }

    $history = $hostInfo.WpfConsole.InputHistory.History

    $lastCommand = $history | select -last 1

    if ($lastCommand)
    {
      $lastCommand = $lastCommand.Trim().ToLower()
      if ($lastCommand.StartsWith("install-package") -and $lastCommand.Contains("awssdk"))
      {
        $dte2.ItemOperations.Navigate($url) | Out-Null
      }
    }
  }
  else
  {
    # user is installing from VS NuGet dialog
    # get reference to the window, then smart output console provider
    # show webpage if messages in buffered console contains "installing...AWSSDK" in last operation

    $instanceField = [NuGet.Dialog.PackageManagerWindow].GetField("CurrentInstance", [System.Reflection.BindingFlags]::Static -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    $consoleField = [NuGet.Dialog.PackageManagerWindow].GetField("_smartOutputConsoleProvider", [System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)

    if ($instanceField -eq $null -or $consoleField -eq $null) { return }

    $instance = $instanceField.GetValue($null)

    if ($instance -eq $null) { return }

    $consoleProvider = $consoleField.GetValue($instance)
    if ($consoleProvider -eq $null) { return }

    $console = $consoleProvider.CreateOutputConsole($false)

    $messagesField = $console.GetType().GetField("_messages", [System.Reflection.BindingFlags]::Instance -bor `
      [System.Reflection.BindingFlags]::NonPublic)
    if ($messagesField -eq $null) { return }

    $messages = $messagesField.GetValue($console)
    if ($messages -eq $null) { return }

    $operations = $messages -split "=============================="

    $lastOperation = $operations | select -last 1

    if ($lastOperation)
    {
      $lastOperation = $lastOperation.ToLower()

      $lines = $lastOperation -split "`r`n"

      $installMatch = $lines | ? { $_.StartsWith("------- installing...awssdk") } | select -first 1

      if ($installMatch)
      {
        $dte2.ItemOperations.Navigate($url) | Out-Null
      }
    }
  }
}
catch
{
  try
  {
    $pmPane = $dte2.ToolWindows.OutputWindow.OutputWindowPanes.Item("Package Manager")

    $selection = $pmPane.TextDocument.Selection
    $selection.StartOfDocument($false)
    $selection.EndOfDocument($true)

    if ($selection.Text.StartsWith("Installing 'awssdk"))
    {
      $dte2.ItemOperations.Navigate($url) | Out-Null
    }
  }
  catch
  {
    # stop potential errors from bubbling up
    # worst case the splash page won't open  
  }
}

function UpdateCurrentProjectsConfigFile([string]$name)
{
    $config = $project.ProjectItems | where {$_.Name -eq "Web.config"}
    if ($config -eq $null)
    {
        $config = $project.ProjectItems | where {$_.Name -eq "App.config"}
        if ($config -eq $null)
        {
            return
        }
    }
    $localPath = $config.Properties | where {$_.Name -eq "LocalPath"}
    UpdateConfigFile($localPath.Value, $name)
}

function UpdateConfigFile([string]$configFilePath, [string]$name)
{
	$references = (Select-String $configFilePath -pattern "AWSProfileName").Matches.Count

	If( $references -ne 0)
	{
		Write-Host "AWSProfileName already exists in config file"
		return
	}

	$xml = New-Object xml
    $xml.Load($configFilePath)

	$appSettingNode = $xml.SelectSingleNode("configuration/appSettings/add[@key = 'AWSProfileName']")

	
	Write-Host "Adding AWSProfileName appSetting to " $configFilePath

    $appSettingsNode = $xml.SelectSingleNode("configuration/appSettings")
    if ($appSettingsNode -eq $null)
    {
        $appSettingsNode = $xml.CreateElement("appSettings")
        $xml.DocumentElement.AppendChild($appSettingsNode)
    }

    if ($name -eq "")
    {    
        $comment = $xml.CreateComment("AWSProfileName is used to reference an account that has been registered with the SDK.`r`nIf using AWS Toolkit for Visual Studio then this value is the same value shown in the AWS Explorer.`r`nIt is also possible to register an account using the <solution-dir>/packages/AWSSDK-X.X.X.X/tools/account-management.ps1 PowerShell script`r`nthat is bundled with the nuget package under the tools folder.`r`n`r`n`t`t<add key=""AWSProfileName"" value="""" />`r`n")
        $appSettingsNode.AppendChild($comment)
    }
    
    $xml.Save($configFilePath)
}


UpdateCurrentProjectsConfigFile ""
# SIG # Begin signature block
# MIIqDAYJKoZIhvcNAQcCoIIp/TCCKfkCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCD5YDSJCqst/cbt
# sDsenRhb8aFQrp5wSSSmT4bMyjoNO6CCDlkwggawMIIEmKADAgECAhAIrUCyYNKc
# TJ9ezam9k67ZMA0GCSqGSIb3DQEBDAUAMGIxCzAJBgNVBAYTAlVTMRUwEwYDVQQK
# EwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3dy5kaWdpY2VydC5jb20xITAfBgNV
# BAMTGERpZ2lDZXJ0IFRydXN0ZWQgUm9vdCBHNDAeFw0yMTA0MjkwMDAwMDBaFw0z
# NjA0MjgyMzU5NTlaMGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwg
# SW5jLjFBMD8GA1UEAxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcg
# UlNBNDA5NiBTSEEzODQgMjAyMSBDQTEwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAw
# ggIKAoICAQDVtC9C0CiteLdd1TlZG7GIQvUzjOs9gZdwxbvEhSYwn6SOaNhc9es0
# JAfhS0/TeEP0F9ce2vnS1WcaUk8OoVf8iJnBkcyBAz5NcCRks43iCH00fUyAVxJr
# Q5qZ8sU7H/Lvy0daE6ZMswEgJfMQ04uy+wjwiuCdCcBlp/qYgEk1hz1RGeiQIXhF
# LqGfLOEYwhrMxe6TSXBCMo/7xuoc82VokaJNTIIRSFJo3hC9FFdd6BgTZcV/sk+F
# LEikVoQ11vkunKoAFdE3/hoGlMJ8yOobMubKwvSnowMOdKWvObarYBLj6Na59zHh
# 3K3kGKDYwSNHR7OhD26jq22YBoMbt2pnLdK9RBqSEIGPsDsJ18ebMlrC/2pgVItJ
# wZPt4bRc4G/rJvmM1bL5OBDm6s6R9b7T+2+TYTRcvJNFKIM2KmYoX7BzzosmJQay
# g9Rc9hUZTO1i4F4z8ujo7AqnsAMrkbI2eb73rQgedaZlzLvjSFDzd5Ea/ttQokbI
# YViY9XwCFjyDKK05huzUtw1T0PhH5nUwjewwk3YUpltLXXRhTT8SkXbev1jLchAp
# QfDVxW0mdmgRQRNYmtwmKwH0iU1Z23jPgUo+QEdfyYFQc4UQIyFZYIpkVMHMIRro
# OBl8ZhzNeDhFMJlP/2NPTLuqDQhTQXxYPUez+rbsjDIJAsxsPAxWEQIDAQABo4IB
# WTCCAVUwEgYDVR0TAQH/BAgwBgEB/wIBADAdBgNVHQ4EFgQUaDfg67Y7+F8Rhvv+
# YXsIiGX0TkIwHwYDVR0jBBgwFoAU7NfjgtJxXWRM3y5nP+e6mK4cD08wDgYDVR0P
# AQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMDMHcGCCsGAQUFBwEBBGswaTAk
# BggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMEEGCCsGAQUFBzAC
# hjVodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkUm9v
# dEc0LmNydDBDBgNVHR8EPDA6MDigNqA0hjJodHRwOi8vY3JsMy5kaWdpY2VydC5j
# b20vRGlnaUNlcnRUcnVzdGVkUm9vdEc0LmNybDAcBgNVHSAEFTATMAcGBWeBDAED
# MAgGBmeBDAEEATANBgkqhkiG9w0BAQwFAAOCAgEAOiNEPY0Idu6PvDqZ01bgAhql
# +Eg08yy25nRm95RysQDKr2wwJxMSnpBEn0v9nqN8JtU3vDpdSG2V1T9J9Ce7FoFF
# UP2cvbaF4HZ+N3HLIvdaqpDP9ZNq4+sg0dVQeYiaiorBtr2hSBh+3NiAGhEZGM1h
# mYFW9snjdufE5BtfQ/g+lP92OT2e1JnPSt0o618moZVYSNUa/tcnP/2Q0XaG3Ryw
# YFzzDaju4ImhvTnhOE7abrs2nfvlIVNaw8rpavGiPttDuDPITzgUkpn13c5Ubdld
# AhQfQDN8A+KVssIhdXNSy0bYxDQcoqVLjc1vdjcshT8azibpGL6QB7BDf5WIIIJw
# 8MzK7/0pNVwfiThV9zeKiwmhywvpMRr/LhlcOXHhvpynCgbWJme3kuZOX956rEnP
# LqR0kq3bPKSchh/jwVYbKyP/j7XqiHtwa+aguv06P0WmxOgWkVKLQcBIhEuWTatE
# QOON8BUozu3xGFYHKi8QxAwIZDwzj64ojDzLj4gLDb879M4ee47vtevLt/B3E+bn
# KD+sEq6lLyJsQfmCXBVmzGwOysWGw/YmMwwHS6DTBwJqakAwSEs0qFEgu60bhQji
# WQ1tygVQK+pKHJ6l/aCnHwZ05/LWUpD9r4VIIflXO7ScA+2GRfS0YW6/aOImYIbq
# yK+p/pQd52MbOoZWeE4wggehMIIFiaADAgECAhALyko14sGCglkXWPsT8gmbMA0G
# CSqGSIb3DQEBCwUAMGkxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5EaWdpQ2VydCwg
# SW5jLjFBMD8GA1UEAxM4RGlnaUNlcnQgVHJ1c3RlZCBHNCBDb2RlIFNpZ25pbmcg
# UlNBNDA5NiBTSEEzODQgMjAyMSBDQTEwHhcNMjExMjI4MDAwMDAwWhcNMjMwMTAz
# MjM1OTU5WjCB9jEdMBsGA1UEDwwUUHJpdmF0ZSBPcmdhbml6YXRpb24xEzARBgsr
# BgEEAYI3PAIBAxMCVVMxGTAXBgsrBgEEAYI3PAIBAhMIRGVsYXdhcmUxEDAOBgNV
# BAUTBzQxNTI5NTQxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAw
# DgYDVQQHEwdTZWF0dGxlMSIwIAYDVQQKExlBbWF6b24gV2ViIFNlcnZpY2VzLCBJ
# bmMuMRcwFQYDVQQLEw5TREtzIGFuZCBUb29sczEiMCAGA1UEAxMZQW1hem9uIFdl
# YiBTZXJ2aWNlcywgSW5jLjCCAaIwDQYJKoZIhvcNAQEBBQADggGPADCCAYoCggGB
# AKHRLdQSyJ6AfhQ8U7Gi6le7gshUhu34xQ7jaTCfpKaKQRGu+oNfAYDRSSfh498e
# K+jFnGHU/TMzVHEgBb4TUrc1e2f5LHhXAtYTJK0uis9OJ5n3MjHwOJt/uGSSMUAI
# IIselvbSF2mOE0lIz0CNMIlUiXI9O+y9+FJP7Vsg/NU/zAVsQ4Ok0GLd+Yp566nR
# uj9aNU+L+TxRhSHA7KKjJ9oE0mVblUGQaeNrOd1Ql9djJy0pg6oT2s9Peh8lqB3t
# UsMaoQ/FMV0P/e1S6V3yFg/I1OvQdtm29ryJTdg9ZvIV/FGnIYdW5s5T8t//nf+7
# LToQVhpML/ZWEhFRAa6We80Y8zs9glIPDZyYmi6OPbpY7kVHa4dr8S49tPwrVMjC
# 3hk9v9S6poDx/hR9kytwVt1Lo4LjAlpmKLeHVmOnn5uenpXqFOJMbTMYmciwHz8y
# WJwZYMKKLJPCGa79xaAkZj9HCop5yPUPccqjyz2i0v/Pt8yFH77s8q86e99O2a+/
# oQIDAQABo4ICNTCCAjEwHwYDVR0jBBgwFoAUaDfg67Y7+F8Rhvv+YXsIiGX0TkIw
# HQYDVR0OBBYEFGmlIp+0bnVEmnOvWcJjnCup9DbsMC4GA1UdEQQnMCWgIwYIKwYB
# BQUHCAOgFzAVDBNVUy1ERUxBV0FSRS00MTUyOTU0MA4GA1UdDwEB/wQEAwIHgDAT
# BgNVHSUEDDAKBggrBgEFBQcDAzCBtQYDVR0fBIGtMIGqMFOgUaBPhk1odHRwOi8v
# Y3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkRzRDb2RlU2lnbmluZ1JT
# QTQwOTZTSEEzODQyMDIxQ0ExLmNybDBToFGgT4ZNaHR0cDovL2NybDQuZGlnaWNl
# cnQuY29tL0RpZ2lDZXJ0VHJ1c3RlZEc0Q29kZVNpZ25pbmdSU0E0MDk2U0hBMzg0
# MjAyMUNBMS5jcmwwPQYDVR0gBDYwNDAyBgVngQwBAzApMCcGCCsGAQUFBwIBFhto
# dHRwOi8vd3d3LmRpZ2ljZXJ0LmNvbS9DUFMwgZQGCCsGAQUFBwEBBIGHMIGEMCQG
# CCsGAQUFBzABhhhodHRwOi8vb2NzcC5kaWdpY2VydC5jb20wXAYIKwYBBQUHMAKG
# UGh0dHA6Ly9jYWNlcnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydFRydXN0ZWRHNENv
# ZGVTaWduaW5nUlNBNDA5NlNIQTM4NDIwMjFDQTEuY3J0MAwGA1UdEwEB/wQCMAAw
# DQYJKoZIhvcNAQELBQADggIBALlYa6PSDPPulVJbqEi7XGz23lFZwYa1PiXk+PkJ
# O2HDXv2zep26LZriwBHT2yA/KbDvbwZpf4VOBKn5lQC9R+DsgwW/xZbNq7y3cWf9
# Ad1AQ9Do/FXfBqVO1if+GpqFbqUme5wOjn8/8dc4nFR4erbDgkM4ICn/astBigYn
# fM5wTO+J8ex+7fE2D1kFAwfZAuiRNdDreVMDlYXpJMQ4CtTKVLHYentLR747zzRj
# O4PqgL1exvbvpOMZlSDLWhaDjtKwUDb645ziHDA3DXe8K51+hIFuadKTinJa8Pfs
# bgg2W7aTfBdi2gTyXkeVJ836631Ks4KD3cXui9Jx2PWRAVxKIEvXuebZ09Mph2ji
# BH75urqS57i1mpS7OA5lIj7a7NIYsVl26PVpJUEr3LRKV8GO3tRC7KP0zE7sB7k2
# VQKwBXbsifq/vpcmeyy4OeQbZ1i8GwZLPHuygP9exTWK2o2wWByJs62Wdk6JmSRE
# vr9Wr59BVNbQfRSRaF9q058bBK68hGZtDBpJ9gJX4V12DI2UpSbcGf10+afL1J4z
# FDv98GIGkgmfLQJUpJeC/FnNrEXJbINndCsOb6gdLvLX1grMdUPmPkpRZyvG3HEy
# EMCV5ODMItTx7K6TDyeZDIXXP5oBnBMK9EjtRD3XkEb9dDfuzCrdlTpEoTElt2mG
# uEE7MYIbCTCCGwUCAQEwfTBpMQswCQYDVQQGEwJVUzEXMBUGA1UEChMORGlnaUNl
# cnQsIEluYy4xQTA/BgNVBAMTOERpZ2lDZXJ0IFRydXN0ZWQgRzQgQ29kZSBTaWdu
# aW5nIFJTQTQwOTYgU0hBMzg0IDIwMjEgQ0ExAhALyko14sGCglkXWPsT8gmbMA0G
# CWCGSAFlAwQCAQUAoHwwEAYKKwYBBAGCNwIBDDECMAAwGQYJKoZIhvcNAQkDMQwG
# CisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZI
# hvcNAQkEMSIEIK61EKI3E83uBQw2QlFhFvOqB2zYRU+jUG2AWNwCS1w5MA0GCSqG
# SIb3DQEBAQUABIIBgFmxk+5K2ZDC/aFp8E1saXKAauRBXbDoshdIIZ6BwuZlpp6v
# Gb32Y3fVkCYqc/lZ+yEiBTbN8tXfxYDH3pl24zX1UOL0WjkxHel46R2rbN7DiRgd
# zgBfwOL2jbHTBSarOK/riuG5nzCFiF9goM4T804l2oSIONBPYuNpG17y0Fr72CHT
# IV/z0+eGCf1j5HEi9lM9CrusjM1zCPp/Hi1CsZbUvgRxuXjlo2rLfVcamMlppGZm
# IsxANr7T967KNEORmdaXNISswg4NBfvnXXvi2JffPfd52MHalEajEY0IWoArmnBQ
# rq5bxNkDN53AEYju6TcqGvgCOr4FmdOibnwrLPLOg7pmhpdqJZLznhYqM+4lbBus
# Cbb6ipnwuCRrE/gx6QblODDaR6/8kEfb1US0uSDrQqZk97YNYZ7GBFs/LCK4dw4K
# TG4ZtmqcqKwM++bwlaDuDH/AmElHm6qtL776SIhc1n0LqjHA0/McuWvVJQ67LOs8
# K1uA0+HzQezW2q92+aGCGF8wghhbBgorBgEEAYI3AwMBMYIYSzCCGEcGCSqGSIb3
# DQEHAqCCGDgwghg0AgEDMQ0wCwYJYIZIAWUDBAIDMIHzBgsqhkiG9w0BCRABBKCB
# 4wSB4DCB3QIBAQYKYIZIAYb6bAoDBTAxMA0GCWCGSAFlAwQCAQUABCCa0NNlprWU
# ZZ5oDMcpZuM4BqYTLMezce4VH1Fuc8ogoQIIenIn5q+06dwYDzIwMjIwNjEzMTkx
# OTA5WjADAgEBoHmkdzB1MQswCQYDVQQGEwJDQTEQMA4GA1UECBMHT250YXJpbzEP
# MA0GA1UEBxMGT3R0YXdhMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSswKQYDVQQD
# EyJFbnRydXN0IFRpbWVzdGFtcCBBdXRob3JpdHkgLSBUU0EyoIITDjCCBd8wggTH
# oAMCAQICEE5A5DdU7eaMAAAAAFHTlH8wDQYJKoZIhvcNAQELBQAwgb4xCzAJBgNV
# BAYTAlVTMRYwFAYDVQQKEw1FbnRydXN0LCBJbmMuMSgwJgYDVQQLEx9TZWUgd3d3
# LmVudHJ1c3QubmV0L2xlZ2FsLXRlcm1zMTkwNwYDVQQLEzAoYykgMjAwOSBFbnRy
# dXN0LCBJbmMuIC0gZm9yIGF1dGhvcml6ZWQgdXNlIG9ubHkxMjAwBgNVBAMTKUVu
# dHJ1c3QgUm9vdCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eSAtIEcyMB4XDTIxMDUw
# NzE1NDM0NVoXDTMwMTEwNzE2MTM0NVowaTELMAkGA1UEBhMCVVMxFjAUBgNVBAoM
# DUVudHJ1c3QsIEluYy4xQjBABgNVBAMMOUVudHJ1c3QgQ29kZSBTaWduaW5nIFJv
# b3QgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgLSBDU0JSMTCCAiIwDQYJKoZIhvcN
# AQEBBQADggIPADCCAgoCggIBAKeBj/cURbZiQ/LYrtMlXkhPUb/FfZ9QHDXR1n5h
# KpQZbSdGpKYaXfdUUWqAIsaoZnVNVIPJXmgbq/ZbZLCtrSC9VO9Ga20C50WudfaO
# irkyLou4dxxSTXmIX6U6GMlQLJcnLb/aAH1jf+8y7EaHY9uan8NaITZ7+ZvVyqBu
# ciz84fGecE0IVhVvkKv7SLq518GCeIVlLn+1ycDiFLc3EUEG4orgqPblfrZ4BQHD
# YO1PB0EuChNJ45Cbf929+qy/ZFHRXJu09VznXP87m6WgGtd9CbLCt/9uHLzIfebp
# K/xysxTpSlUShJxEJXUd9irwT6UgPWgl62GXfA/ltj3zrsPBEbwbjszgRzBeQgCG
# ceNYrAbKZR97lKZLV2cMfl6teGdbVeNe68fY7Exuhsvz3Pifh6pyWBIPfab4+EI5
# Ozws5DJNSYzg4QDCOKCc+oQ+QdxuVq7GGlv0Z2gFAc0bv66HvJ1T9i7otmvkmd7F
# T4dYqNJlHsgf1XJu7lkcVzsJcp3XyreQxs17RZKRQgNMfT/K8qq4wg6G8xCfRi6k
# ZoZoWmgYcCk4EYBga4pDo3Ns47NrN//mnWcBkobfL0jR+1Bg1Vz+IdMBQmP+73C0
# F8CPqO7TwUtfEur9/S4Oh0Rg46n0whij4/3ODIQiDfOneNqT89s4z7kvM8b/Bzxe
# vkXTAgMBAAGjggErMIIBJzAOBgNVHQ8BAf8EBAMCAYYwEgYDVR0TAQH/BAgwBgEB
# /wIBATAdBgNVHSUEFjAUBggrBgEFBQcDAwYIKwYBBQUHAwgwOwYDVR0gBDQwMjAw
# BgRVHSAAMCgwJgYIKwYBBQUHAgEWGmh0dHA6Ly93d3cuZW50cnVzdC5uZXQvcnBh
# MDMGCCsGAQUFBwEBBCcwJTAjBggrBgEFBQcwAYYXaHR0cDovL29jc3AuZW50cnVz
# dC5uZXQwMAYDVR0fBCkwJzAloCOgIYYfaHR0cDovL2NybC5lbnRydXN0Lm5ldC9n
# MmNhLmNybDAdBgNVHQ4EFgQUgrrWPZfOn89x6JI3r/2ztWk1V88wHwYDVR0jBBgw
# FoAUanImetAe733nO2lR1GyNn5ASZqswDQYJKoZIhvcNAQELBQADggEBAB9eQQS2
# g3AkUyxVcx1lOsDstHsEmF5ZOBMJpFmUQl5Qv09sbiUgkJNYQA31GbRi7iRewgFY
# FQIdEAlvqNT7kn43OD4vFH2PHUM2ZLNmE18UzKVx91shS8aXvtyV/HB9ERzTId3Q
# JDkpxf4KGqXPe3nuOm/e3L/pEd0WgwjTLI1/TagUeS8FYVI462DzFGh9y7KKrcCU
# XOQmDiyK3UbDzuRWUcVW44W4TZtFcosH8Yr7Sbhf0fKWgV1pUiTxCCPS1iMP64vX
# fovBk2v68WJ7WOlQm5duF4gN4cZDmNeBYbaFnUfssZ6uPyA7Q53Yohzg1HwIwq92
# BvhiZnq29/rIrzUwggZvMIIEV6ADAgECAhAlvCvzKcoQfx6puoiF1J07MA0GCSqG
# SIb3DQEBDQUAMGkxCzAJBgNVBAYTAlVTMRYwFAYDVQQKDA1FbnRydXN0LCBJbmMu
# MUIwQAYDVQQDDDlFbnRydXN0IENvZGUgU2lnbmluZyBSb290IENlcnRpZmljYXRp
# b24gQXV0aG9yaXR5IC0gQ1NCUjEwHhcNMjEwNTA3MTkyMjE0WhcNNDAxMjI5MjM1
# OTAwWjBOMQswCQYDVQQGEwJVUzEWMBQGA1UEChMNRW50cnVzdCwgSW5jLjEnMCUG
# A1UEAxMeRW50cnVzdCBUaW1lIFN0YW1waW5nIENBIC0gVFMyMIICIjANBgkqhkiG
# 9w0BAQEFAAOCAg8AMIICCgKCAgEAtQMqBraETzTMnjG+6o7Ge24gJA8D172BNjPm
# b9I+u8SeqqDMZl1CYDRR4i1hg7o8nmi4S8NmjqXeK7qbLUGl3tDLVwUtiNnARoht
# PDUNGZCsuAwZ8EzF20Vb3DvCvI1EAOA4//9dyM8Imj3Usut7lcPEpQDgYgFkWV+M
# 43uLqflFt8awogo3Q7hGgauGfn8v3vBf680gzKUtMeOoLpmb4Hjd9NtdgmN9MDmI
# fiQG5nxghHjIXCnllcv1e0/PWNyQz6eiexRUxOA3mDDBm7aunCn2ayVD5xJqPhmL
# vsDngddKMAh+fI3fPPNIkyHegYNqnQA+12C60bNiCJbptkkAOPRcdg3ad2o9oJXe
# HqHMWXpen8/pdl1A8rUVtWBoLPNaySOD2PUaa2kopLbUrmIG3iZFvd7pVneq3GSw
# Qc3ME/FdcXSylAhLTzJufnC4d+nVMjfCet5CEuhxHOLYYr+qa0GGBlvmab4mCfSX
# wv5M9IByhG7b3sUHqY4Vom3hG+AJD/WgB6C7xHdzCTwHk40BtRJnLU0ZtbjFyRCr
# cM9C/6UnHdYS1uQYRGD7OV2Eu2a1UxKdAxSCZSm07Ely/bND5cMCKSS6H/i4vl2j
# ty6p/M9i2fqXxBN441W5WnqE6/+7z2mIwLb5i2CFQRBQxwUQ0l52nT417PZPivkS
# ez+vCzcCAwEAAaOCASwwggEoMBIGA1UdEwEB/wQIMAYBAf8CAQAwHQYDVR0OBBYE
# FCYP8MRICBvN3ZH1VFS2s7P8mfEIMB8GA1UdIwQYMBaAFIK61j2Xzp/PceiSN6/9
# s7VpNVfPMDMGCCsGAQUFBwEBBCcwJTAjBggrBgEFBQcwAYYXaHR0cDovL29jc3Au
# ZW50cnVzdC5uZXQwMQYDVR0fBCowKDAmoCSgIoYgaHR0cDovL2NybC5lbnRydXN0
# Lm5ldC9jc2JyMS5jcmwwDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUF
# BwMIMEUGA1UdIAQ+MDwwMAYEVR0gADAoMCYGCCsGAQUFBwIBFhpodHRwOi8vd3d3
# LmVudHJ1c3QubmV0L3JwYTAIBgZngQwBBAIwDQYJKoZIhvcNAQENBQADggIBAHY9
# RmiFXwnAzsn4x7jXfqdcOwtGc84iU4s49hG6d8TChyGPJ9kMlevoS+Vc15AVb6gq
# LIpq4CIRNHn6vZZ5yHYWzbFE6nFRD5tVyRh81YJ5nPOmt5OpBThyAgaXoaiyeX5e
# COJubHmaqIeUzn+PVTZAD58/UdVmvnurhuZuh7pOY12x2I4fy2fDDXDaeuuTshSE
# 0j59kz8WDDagXHkAnwtu5YQq2IjBbQS3N/OSmnDgOwP9zbsngs4v/I3kssq++CWF
# xu10yD01XzgJPXlP6xvgQV6ldIE/URXA+EmIj7q7BdStRYIzecEljV9UPZHkuJ8X
# mABdrSjlT18b+/hUtaXEJPzwdjv4DV7MR7DKqrtuUd9TtUka8WCHt/n9aQZ1X3PW
# EZDygFiO5cMPA5iMBFOzKYffP/ew6UxXgSREeWj+GzYH1mU97G/WwrWqYXxmBuzS
# 5WmA+HGSLlziEUYYRUvW+gVk77veBspDJb3fjckBdGGI2/DHpj3jDHG8f0vnyOBu
# 4NqA+QCewGsl1aO6XCv+xGAgFEoHIzHlGsuRRLKae0PxW5i1IUu4MTsiVO55Yfea
# lBtmJyrG3+FlXe9xOeZQJf2HNLmuXXwnO+dlk/gohLFvhpMsk5O2cK+h7sikYamE
# O/sKt/i4bSbuR071XgX6nA8RfdfLka5DIPcVWWO8MIIGtDCCBJygAwIBAgIQdNny
# 21E8Imf9R5w2Bz97HTANBgkqhkiG9w0BAQ0FADBOMQswCQYDVQQGEwJVUzEWMBQG
# A1UEChMNRW50cnVzdCwgSW5jLjEnMCUGA1UEAxMeRW50cnVzdCBUaW1lIFN0YW1w
# aW5nIENBIC0gVFMyMB4XDTIxMDUxNDAwMDAwMFoXDTMyMDgxNDAwMDAwMFowdTEL
# MAkGA1UEBhMCQ0ExEDAOBgNVBAgTB09udGFyaW8xDzANBgNVBAcTBk90dGF3YTEW
# MBQGA1UEChMNRW50cnVzdCwgSW5jLjErMCkGA1UEAxMiRW50cnVzdCBUaW1lc3Rh
# bXAgQXV0aG9yaXR5IC0gVFNBMjCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoC
# ggIBAK+/LEa8azGwJn8Cpvhw62SW6EoaKQxBXOAcSqW5gjOTps5WBh+UnqlRAhmN
# u/IPntuJ0DOEWOMOoN75UkEgvGDXC2GnT29CTHCcnCkjC8Knwlzdnrgs8164QblI
# yjNwNBN191BebSZuxRQzMRfNgbu6ElCgrMF7BYNyEG8pQ/wbaS/FwuuF14OVYAgj
# dd9cIv+kgQbRzvC3XBxOmbCopB2A43A82Hlew8kJB9kzkjWWIUl/1Ot40vin8wu5
# SoARNaks2EKbtm6Yq1DDUKEt9t3ypzGfGwtnVTOeGHvMYguU1CPTpem6KWMRJWZn
# lFv/O3k4sNMtFnWJ9PN4kFq/a34XqoOk8VCBnILcHspisXUPiL8NF3oK7QPEDY+1
# 7ywl1YiU51wW03hPsvI0e1lJGM/Kg9xQAL4ib8pUvCYnJzqnrco4PgyvqCHtlXLo
# 1dJ7eBLxnmLZ/gLfoLvJfvBkbMjYrUPkKc1nvJtNBW5zrh4MdIOg1/Go0RO6xpPd
# Ee4Eo1lhDaIBJFcWPzMEZGoGB9dpVvGKZKkYPwmwDDwH9Qo/mdSF5w+XwdErwx2u
# h9tydRjzm3ZVQAnHVZwsRken2kyjnBHv4XRUd3t4wLYU4s/anNRGXdDWCpMfASfn
# 2PzDCmzffK1PHZCz1o4n6Ka/S0ZxZjrG+WjpRPp5BwZN7xu9AgMBAAGjggFlMIIB
# YTAMBgNVHRMBAf8EAjAAMB0GA1UdDgQWBBTC9dEWwc29rXhhVM4IFG72AQ++ZjAf
# BgNVHSMEGDAWgBQmD/DESAgbzd2R9VRUtrOz/JnxCDBoBggrBgEFBQcBAQRcMFow
# IwYIKwYBBQUHMAGGF2h0dHA6Ly9vY3NwLmVudHJ1c3QubmV0MDMGCCsGAQUFBzAC
# hidodHRwOi8vYWlhLmVudHJ1c3QubmV0L3RzMi1jaGFpbjI1Ni5jZXIwMQYDVR0f
# BCowKDAmoCSgIoYgaHR0cDovL2NybC5lbnRydXN0Lm5ldC90czJjYS5jcmwwDgYD
# VR0PAQH/BAQDAgeAMBYGA1UdJQEB/wQMMAoGCCsGAQUFBwMIMEwGA1UdIARFMEMw
# NwYKYIZIAYb6bAoDBTApMCcGCCsGAQUFBwIBFhtodHRwczovL3d3dy5lbnRydXN0
# Lm5ldC9ycGEwCAYGZ4EMAQQCMA0GCSqGSIb3DQEBDQUAA4ICAQB1IotTwHGXTkoF
# rU0ODiuUQOK8p/ujaCXErVBnNcsUvHSWYHn/4bF7Dz9o6/KG+R09T1e6Lsgn06e7
# J4uT4+oYz1Esf6I6xZ/gmwArdCjyluD0whqEWLbnkIvF7EkGvOgRBBSW1b/dnp1K
# MK/hyuZrqATSq6eRIq/N/GZZf1omY7pnQIYoi+zdjiO6OEDcwwvWP0KO+c4CaDOL
# S6gb5pmmbF4ca42N5C9rgE0Nz5JiYnjWC8FcgbrszTuOi1uuawDbuByfMMiZAo0N
# GnBZM//Yn7wQUKTAwBX7L9oEY+w5OoK9xSdLZIK1XQ9w53zSVRXINhK1/vJaCGSa
# g/DJi2k8+rlyPstP14lyDBMXQFI6ufgQEk3k6C1a1dj6zJkBgkzSFC/dZWbOMQIv
# Xtk8X5Phkpy41lWtDrSv6/UzvzYXYbQ0Nnjs9gqNcoN0FRO8CHYby/wWnWD/pv8I
# m/x5UyJ2skI22Y4n93jw4XN/MGqwsGRn1rsBT414ene2wX19f3roVOT3rtr0SDB5
# ++YoY718HOn3s7S1dg95xNXtYRMbcUaWHWbeEqZqHx2rtW7/WB5HkP/qZTpIHQsg
# SYUiR3S2AaKwud/ghu1T3ZimLa7hvShHJudtMxoih6vH/vMbagTIud/bsvs925oj
# yXOeX8fYXKIEmxLBqqKOG/wUEZJt3DGCBBYwggQSAgEBMGIwTjELMAkGA1UEBhMC
# VVMxFjAUBgNVBAoTDUVudHJ1c3QsIEluYy4xJzAlBgNVBAMTHkVudHJ1c3QgVGlt
# ZSBTdGFtcGluZyBDQSAtIFRTMgIQdNny21E8Imf9R5w2Bz97HTALBglghkgBZQME
# AgOgggGJMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRABBDAcBgkqhkiG9w0BCQUx
# DxcNMjIwNjEzMTkxOTA5WjApBgkqhkiG9w0BCTQxHDAaMAsGCWCGSAFlAwQCA6EL
# BgkqhkiG9w0BAQ0wTwYJKoZIhvcNAQkEMUIEQPOqRqu/2kqC9xl4WhD2DavC3srT
# yCT8NJjPtq2f9t3WM7PlKNgHq0ep22UtEfBaAcYOPnldH0nITO9T7GvUoDEwgdAG
# CyqGSIb3DQEJEAIvMYHAMIG9MIG6MIG3MAsGCWCGSAFlAwQCAwRAYHlfLRbGnFn9
# od5ZY63P46SIFLZc6BFL1b/uDxK7PPBWMeQkFLkZuMEx1qut5ULXgsiKMZBlL0sK
# /PIZEck3jDBmMFKkUDBOMQswCQYDVQQGEwJVUzEWMBQGA1UEChMNRW50cnVzdCwg
# SW5jLjEnMCUGA1UEAxMeRW50cnVzdCBUaW1lIFN0YW1waW5nIENBIC0gVFMyAhB0
# 2fLbUTwiZ/1HnDYHP3sdMAsGCSqGSIb3DQEBDQSCAgAm5wlBqPe8hzy8vETa3ZVg
# JF91DxyaG6+/To/fTQOuC5qEY9L8nvWMAsMr1Ag+pQeFgFXBCE1tkdLRGbXpCG3P
# Q3uIURL9kAlO6p+sNGZlgsEWIoeTL08+T21uhsFJ85koYUetDfRaVJ5Dfd1LzKHn
# OUBiJRGx6LU8IhSgQvoz1EUlh2D1ZRjWiFqOLHjEYwPwFMwqmZUsT4UN+Cv4ERKw
# +Us/nrWfR/hoy8qPuhFopDilj1cn0eWjEAPJYB9LRC7N9qDwwlvqObgJgS2Doa7u
# 9C0UKuT14i079yE41sG/EnzNpg7mPvqjWtGsoYCM4uUIQPezbIkFg22AJiv3kEeQ
# pFClrug4UYNGfMh8MR+cn7Za3ucGArJMbAz8ESTOa6n9gvC0IElBoRJC+ixyvXcR
# 0ENvPq+BZtCnJsDSTjSbeFxXKKGwJWjouZKKOJ3NPoiu7dgHAZ+9mqjYJBmR4IW+
# 5kxl6bn7vBj4e/Isq3dk2I144uGbvK7ZfKG17wV6/C39csRJMzlBSgjMFPxtS+2W
# kaiGihS5yogN6+GmJr/M/a4f/ma147No5nQeOgYqCAsJN6sC3YXxYC10WgqRWhqh
# mosnt0mbZEtEDC/ZXfM4InMgY7u7GkMRr2RqTsrSadYsX9lmO1CJ1v6R1vvdb1Pi
# ShD2rqWzw7u+nT6wGigNqg==
# SIG # End signature block
