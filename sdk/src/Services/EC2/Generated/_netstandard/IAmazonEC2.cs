/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides secure and resizable computing
    /// capacity in the AWS Cloud. Using Amazon EC2 eliminates the need to invest in hardware
    /// up front, so you can develop and deploy applications faster. Amazon Virtual Private
    /// Cloud (Amazon VPC) enables you to provision a logically isolated section of the AWS
    /// Cloud where you can launch AWS resources in a virtual network that you've defined.
    /// Amazon Elastic Block Store (Amazon EBS) provides block level storage volumes for use
    /// with EC2 instances. EBS volumes are highly available and reliable storage volumes
    /// that can be attached to any running instance and used like a hard drive.
    /// </para>
    ///  
    /// <para>
    /// To learn more, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon EC2: <a href="http://aws.amazon.com/ec2">AmazonEC2 product page</a>, <a href="http://aws.amazon.com/documentation/ec2">Amazon
    /// EC2 documentation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EBS: <a href="http://aws.amazon.com/ebs">Amazon EBS product page</a>, <a href="http://aws.amazon.com/documentation/ebs">Amazon
    /// EBS documentation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon VPC: <a href="http://aws.amazon.com/vpc">Amazon VPC product page</a>, <a href="http://aws.amazon.com/documentation/vpc">Amazon
    /// VPC documentation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS VPN: <a href="http://aws.amazon.com/vpn">AWS VPN product page</a>, <a href="http://aws.amazon.com/documentation/vpn">AWS
    /// VPN documentation</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonEC2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEC2PaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptReservedInstancesExchangeQuote



        /// <summary>
        /// Accepts the Convertible Reserved Instance exchange quote described in the <a>GetReservedInstancesExchangeQuote</a>
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        Task<AcceptReservedInstancesExchangeQuoteResponse> AcceptReservedInstancesExchangeQuoteAsync(AcceptReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptTransitGatewayMulticastDomainAssociations



        /// <summary>
        /// Accepts a request to associate subnets with a transit gateway multicast domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptTransitGatewayMulticastDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptTransitGatewayMulticastDomainAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptTransitGatewayMulticastDomainAssociations">REST API Reference for AcceptTransitGatewayMulticastDomainAssociations Operation</seealso>
        Task<AcceptTransitGatewayMulticastDomainAssociationsResponse> AcceptTransitGatewayMulticastDomainAssociationsAsync(AcceptTransitGatewayMulticastDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptTransitGatewayPeeringAttachment



        /// <summary>
        /// Accepts a transit gateway peering attachment request. The peering attachment must
        /// be in the <code>pendingAcceptance</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptTransitGatewayPeeringAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptTransitGatewayPeeringAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptTransitGatewayPeeringAttachment">REST API Reference for AcceptTransitGatewayPeeringAttachment Operation</seealso>
        Task<AcceptTransitGatewayPeeringAttachmentResponse> AcceptTransitGatewayPeeringAttachmentAsync(AcceptTransitGatewayPeeringAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptTransitGatewayVpcAttachment



        /// <summary>
        /// Accepts a request to attach a VPC to a transit gateway.
        /// 
        ///  
        /// <para>
        /// The VPC attachment must be in the <code>pendingAcceptance</code> state. Use <a>DescribeTransitGatewayVpcAttachments</a>
        /// to view your pending VPC attachment requests. Use <a>RejectTransitGatewayVpcAttachment</a>
        /// to reject a VPC attachment request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptTransitGatewayVpcAttachment">REST API Reference for AcceptTransitGatewayVpcAttachment Operation</seealso>
        Task<AcceptTransitGatewayVpcAttachmentResponse> AcceptTransitGatewayVpcAttachmentAsync(AcceptTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptVpcEndpointConnections



        /// <summary>
        /// Accepts one or more interface VPC endpoint connection requests to your VPC endpoint
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        Task<AcceptVpcEndpointConnectionsResponse> AcceptVpcEndpointConnectionsAsync(AcceptVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptVpcPeeringConnection



        /// <summary>
        /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
        /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
        /// the peer VPC. Use <a>DescribeVpcPeeringConnections</a> to view your outstanding VPC
        /// peering connection requests.
        /// 
        ///  
        /// <para>
        /// For an inter-Region VPC peering connection request, you must accept the VPC peering
        /// connection in the Region of the accepter VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdvertiseByoipCidr



        /// <summary>
        /// Advertises an IPv4 or IPv6 address range that is provisioned for use with your Amazon
        /// Web Services resources through bring your own IP addresses (BYOIP).
        /// 
        ///  
        /// <para>
        /// You can perform this operation at most once every 10 seconds, even if you specify
        /// different address ranges each time.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you stop advertising the BYOIP CIDR from other locations when you
        /// advertise it from Amazon Web Services. To minimize down time, you can configure your
        /// Amazon Web Services resources to use an address from a BYOIP CIDR before it is advertised,
        /// and then simultaneously stop advertising it from the current location and start advertising
        /// it through Amazon Web Services.
        /// </para>
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses starts routing
        /// to Amazon Web Services because of BGP propagation delays.
        /// </para>
        ///  
        /// <para>
        /// To stop advertising the BYOIP CIDR, use <a>WithdrawByoipCidr</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdvertiseByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        Task<AdvertiseByoipCidrResponse> AdvertiseByoipCidrAsync(AdvertiseByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AllocateAddress


        /// <summary>
        /// Allocates an Elastic IP address to your Amazon Web Services account. After you allocate
        /// the Elastic IP address you can associate it with an instance or network interface.
        /// After you release an Elastic IP address, it is released to the IP address pool and
        /// can be allocated to a different Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can allocate an Elastic IP address from an address pool owned by Amazon Web Services
        /// or from an address pool created from a public IPv4 address range that you have brought
        /// to Amazon Web Services for use with your Amazon Web Services resources using bring
        /// your own IP addresses (BYOIP). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
        /// cannot recover an Elastic IP address that you released after it is allocated to another
        /// Amazon Web Services account. You cannot recover an Elastic IP address for EC2-Classic.
        /// To attempt to recover an Elastic IP address that you released, specify it in this
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per Region and 5
        /// Elastic IP addresses for EC2-VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can allocate a carrier IP address which is a public IP address from a telecommunication
        /// carrier, to a network interface which resides in a subnet in a Wavelength Zone (for
        /// example an EC2 instance). 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        Task<AllocateAddressResponse> AllocateAddressAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Allocates an Elastic IP address to your Amazon Web Services account. After you allocate
        /// the Elastic IP address you can associate it with an instance or network interface.
        /// After you release an Elastic IP address, it is released to the IP address pool and
        /// can be allocated to a different Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can allocate an Elastic IP address from an address pool owned by Amazon Web Services
        /// or from an address pool created from a public IPv4 address range that you have brought
        /// to Amazon Web Services for use with your Amazon Web Services resources using bring
        /// your own IP addresses (BYOIP). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
        /// cannot recover an Elastic IP address that you released after it is allocated to another
        /// Amazon Web Services account. You cannot recover an Elastic IP address for EC2-Classic.
        /// To attempt to recover an Elastic IP address that you released, specify it in this
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per Region and 5
        /// Elastic IP addresses for EC2-VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can allocate a carrier IP address which is a public IP address from a telecommunication
        /// carrier, to a network interface which resides in a subnet in a Wavelength Zone (for
        /// example an EC2 instance). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AllocateHosts



        /// <summary>
        /// Allocates a Dedicated Host to your account. At a minimum, specify the supported instance
        /// type or instance family, the Availability Zone in which to allocate the host, and
        /// the number of hosts to allocate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        Task<AllocateHostsResponse> AllocateHostsAsync(AllocateHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AllocateIpamPoolCidr



        /// <summary>
        /// Allocate a CIDR from an IPAM pool. In IPAM, an allocation is a CIDR assignment from
        /// an IPAM pool to another resource or IPAM pool. For more information, see <a href="/vpc/latest/ipam/allocate-cidrs-ipam.html">Allocate
        /// CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateIpamPoolCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateIpamPoolCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateIpamPoolCidr">REST API Reference for AllocateIpamPoolCidr Operation</seealso>
        Task<AllocateIpamPoolCidrResponse> AllocateIpamPoolCidrAsync(AllocateIpamPoolCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApplySecurityGroupsToClientVpnTargetNetwork



        /// <summary>
        /// Applies a security group to the association between the target network and the Client
        /// VPN endpoint. This action replaces the existing security groups with the specified
        /// security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ApplySecurityGroupsToClientVpnTargetNetwork">REST API Reference for ApplySecurityGroupsToClientVpnTargetNetwork Operation</seealso>
        Task<ApplySecurityGroupsToClientVpnTargetNetworkResponse> ApplySecurityGroupsToClientVpnTargetNetworkAsync(ApplySecurityGroupsToClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssignIpv6Addresses



        /// <summary>
        /// Assigns one or more IPv6 addresses to the specified network interface. You can specify
        /// one or more specific IPv6 addresses, or you can specify the number of IPv6 addresses
        /// to be automatically assigned from within the subnet's IPv6 CIDR block range. You can
        /// assign as many IPv6 addresses to a network interface as you can assign private IPv4
        /// addresses, and the limit varies per instance type. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">IP
        /// Addresses Per Network Interface Per Instance Type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify either the IPv6 addresses or the IPv6 address count in the request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally use Prefix Delegation on the network interface. You must specify
        /// either the IPV6 Prefix Delegation prefixes, or the IPv6 Prefix Delegation count. For
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">
        /// Assigning prefixes to Amazon EC2 network interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        Task<AssignIpv6AddressesResponse> AssignIpv6AddressesAsync(AssignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssignPrivateIpAddresses



        /// <summary>
        /// Assigns one or more secondary private IP addresses to the specified network interface.
        /// 
        ///  
        /// <para>
        /// You can specify one or more specific secondary IP addresses, or you can specify the
        /// number of secondary IP addresses to be automatically assigned within the subnet's
        /// CIDR block range. The number of secondary IP addresses that you can assign to an instance
        /// varies by instance type. For information about instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more information
        /// about Elastic IP addresses, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you move a secondary private IP address to another network interface, any Elastic
        /// IP address that is associated with the IP address is also moved.
        /// </para>
        ///  
        /// <para>
        /// Remapping an IP address is an asynchronous operation. When you move an IP address
        /// from one network interface to another, check <code>network/interfaces/macs/mac/local-ipv4s</code>
        /// in the instance metadata to confirm that the remapping is complete.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the IP addresses or the IP address count in the request.
        /// </para>
        ///  
        /// <para>
        /// You can optionally use Prefix Delegation on the network interface. You must specify
        /// either the IPv4 Prefix Delegation prefixes, or the IPv4 Prefix Delegation count. For
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">
        /// Assigning prefixes to Amazon EC2 network interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateAddress



        /// <summary>
        /// Associates an Elastic IP address, or carrier IP address (for instances that are in
        /// subnets in Wavelength Zones) with an instance or a network interface. Before you can
        /// use an Elastic IP address, you must allocate it to your account.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, VPC in an EC2-VPC-only account] If the Elastic IP address is already
        /// associated with a different instance, it is disassociated from that instance and associated
        /// with the specified instance. If you associate an Elastic IP address with an instance
        /// that has an existing Elastic IP address, the existing address is disassociated from
        /// the instance, but remains allocated to your account.
        /// </para>
        ///  
        /// <para>
        /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
        /// IP address is associated with the primary IP address. If the Elastic IP address is
        /// already associated with a different instance or a network interface, you get an error
        /// unless you allow reassociation. You cannot associate an Elastic IP address with an
        /// instance or network interface that has an existing Elastic IP address.
        /// </para>
        ///  
        /// <para>
        /// [Subnets in Wavelength Zones] You can associate an IP address from the telecommunication
        /// carrier to the instance or network interface. 
        /// </para>
        ///  
        /// <para>
        /// You cannot associate an Elastic IP address with an interface in a different network
        /// border group.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error, and you may be charged for each time the Elastic IP address
        /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
        /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateClientVpnTargetNetwork



        /// <summary>
        /// Associates a target network with a Client VPN endpoint. A target network is a subnet
        /// in a VPC. You can associate multiple subnets from the same VPC with a Client VPN endpoint.
        /// You can associate only one subnet in each Availability Zone. We recommend that you
        /// associate at least two subnets to provide Availability Zone redundancy.
        /// 
        ///  
        /// <para>
        /// If you specified a VPC when you created the Client VPN endpoint or if you have previous
        /// subnet associations, the specified subnet must be in the same VPC. To specify a subnet
        /// that's in a different VPC, you must first modify the Client VPN endpoint (<a>ModifyClientVpnEndpoint</a>)
        /// and change the VPC that's associated with it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateClientVpnTargetNetwork">REST API Reference for AssociateClientVpnTargetNetwork Operation</seealso>
        Task<AssociateClientVpnTargetNetworkResponse> AssociateClientVpnTargetNetworkAsync(AssociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateDhcpOptions



        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the specified
        /// VPC, or associates no DHCP options with the VPC.
        /// 
        ///  
        /// <para>
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. You don't need to restart or relaunch
        /// the instances. They automatically pick up the changes within a few hours, depending
        /// on how frequently the instance renews its DHCP lease. You can explicitly renew the
        /// lease using the operating system on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
        /// options sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateEnclaveCertificateIamRole



        /// <summary>
        /// Associates an Identity and Access Management (IAM) role with an Certificate Manager
        /// (ACM) certificate. This enables the certificate to be used by the ACM for Nitro Enclaves
        /// application inside an enclave. For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html">Certificate
        /// Manager for Nitro Enclaves</a> in the <i>Amazon Web Services Nitro Enclaves User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When the IAM role is associated with the ACM certificate, the certificate, certificate
        /// chain, and encrypted private key are placed in an Amazon S3 bucket that only the associated
        /// IAM role can access. The private key of the certificate is encrypted with an Amazon
        /// Web Services managed key that has an attached attestation-based key policy.
        /// </para>
        ///  
        /// <para>
        /// To enable the IAM role to access the Amazon S3 object, you must grant it permission
        /// to call <code>s3:GetObject</code> on the Amazon S3 bucket returned by the command.
        /// To enable the IAM role to access the KMS key, you must grant it permission to call
        /// <code>kms:Decrypt</code> on the KMS key returned by the command. For more information,
        /// see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html#add-policy">
        /// Grant the role permission to access the certificate and encryption key</a> in the
        /// <i>Amazon Web Services Nitro Enclaves User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnclaveCertificateIamRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEnclaveCertificateIamRole service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateEnclaveCertificateIamRole">REST API Reference for AssociateEnclaveCertificateIamRole Operation</seealso>
        Task<AssociateEnclaveCertificateIamRoleResponse> AssociateEnclaveCertificateIamRoleAsync(AssociateEnclaveCertificateIamRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateIamInstanceProfile



        /// <summary>
        /// Associates an IAM instance profile with a running or stopped instance. You cannot
        /// associate more than one IAM instance profile with an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        Task<AssociateIamInstanceProfileResponse> AssociateIamInstanceProfileAsync(AssociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateInstanceEventWindow



        /// <summary>
        /// Associates one or more targets with an event window. Only one type of target (instance
        /// IDs, Dedicated Host IDs, or tags) can be specified with an event window.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateInstanceEventWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateInstanceEventWindow service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateInstanceEventWindow">REST API Reference for AssociateInstanceEventWindow Operation</seealso>
        Task<AssociateInstanceEventWindowResponse> AssociateInstanceEventWindowAsync(AssociateInstanceEventWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateRouteTable



        /// <summary>
        /// Associates a subnet in your VPC or an internet gateway or virtual private gateway
        /// attached to your VPC with a route table in your VPC. This association causes traffic
        /// from the subnet or gateway to be routed according to the routes in the route table.
        /// The action returns an association ID, which you need in order to disassociate the
        /// route table later. A route table can be associated with multiple subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateSubnetCidrBlock



        /// <summary>
        /// Associates a CIDR block with your subnet. You can only associate a single IPv6 CIDR
        /// block with your subnet. An IPv6 CIDR block must have a prefix length of /64.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        Task<AssociateSubnetCidrBlockResponse> AssociateSubnetCidrBlockAsync(AssociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTransitGatewayMulticastDomain



        /// <summary>
        /// Associates the specified subnets and transit gateway attachments with the specified
        /// transit gateway multicast domain.
        /// 
        ///  
        /// <para>
        /// The transit gateway attachment must be in the available state before you can add a
        /// resource. Use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeTransitGatewayAttachments.html">DescribeTransitGatewayAttachments</a>
        /// to see the state of the attachment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayMulticastDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTransitGatewayMulticastDomain service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateTransitGatewayMulticastDomain">REST API Reference for AssociateTransitGatewayMulticastDomain Operation</seealso>
        Task<AssociateTransitGatewayMulticastDomainResponse> AssociateTransitGatewayMulticastDomainAsync(AssociateTransitGatewayMulticastDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTransitGatewayRouteTable



        /// <summary>
        /// Associates the specified attachment with the specified transit gateway route table.
        /// You can associate only one route table with an attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateTransitGatewayRouteTable">REST API Reference for AssociateTransitGatewayRouteTable Operation</seealso>
        Task<AssociateTransitGatewayRouteTableResponse> AssociateTransitGatewayRouteTableAsync(AssociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTrunkInterface



        /// <summary>
        /// <note> 
        /// <para>
        /// This API action is currently in <b>limited preview only</b>. If you are interested
        /// in using this feature, contact your account manager.
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a branch network interface with a trunk network interface.
        /// </para>
        ///  
        /// <para>
        /// Before you create the association, run the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html">create-network-interface</a>
        /// command and set <code>--interface-type</code> to <code>trunk</code>. You must also
        /// create a network interface for each branch network interface that you want to associate
        /// with the trunk network interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrunkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrunkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateTrunkInterface">REST API Reference for AssociateTrunkInterface Operation</seealso>
        Task<AssociateTrunkInterfaceResponse> AssociateTrunkInterfaceAsync(AssociateTrunkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateVpcCidrBlock



        /// <summary>
        /// Associates a CIDR block with your VPC. You can associate a secondary IPv4 CIDR block,
        /// an Amazon-provided IPv6 CIDR block, or an IPv6 CIDR block from an IPv6 address pool
        /// that you provisioned through bring your own IP addresses (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">BYOIP</a>).
        /// The IPv6 CIDR block size is fixed at /56.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following in the request: an IPv4 CIDR block, an IPv6
        /// pool, or an Amazon-provided IPv6 CIDR block.
        /// </para>
        ///  
        /// <para>
        /// For more information about associating CIDR blocks with your VPC and applicable restrictions,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html#VPC_Sizing">VPC
        /// and subnet sizing</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockAsync(AssociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachClassicLinkVpc



        /// <summary>
        /// Links an EC2-Classic instance to a ClassicLink-enabled VPC through one or more of
        /// the VPC's security groups. You cannot link an EC2-Classic instance to more than one
        /// VPC at a time. You can only link an instance that's in the <code>running</code> state.
        /// An instance is automatically unlinked from a VPC when it's stopped - you can link
        /// it to the VPC again when you restart it.
        /// 
        ///  
        /// <para>
        /// After you've linked an instance, you cannot change the VPC security groups that are
        /// associated with it. To change the security groups, you must first unlink the instance,
        /// and then link it again.
        /// </para>
        ///  
        /// <para>
        /// Linking your instance to a VPC is sometimes referred to as <i>attaching</i> your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachInternetGateway



        /// <summary>
        /// Attaches an internet gateway or a virtual private gateway to a VPC, enabling connectivity
        /// between the internet and the VPC. For more information about your VPC and internet
        /// gateway, see the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachNetworkInterface



        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachVolume



        /// <summary>
        /// Attaches an EBS volume to a running or stopped instance and exposes it to the instance
        /// with the specified device name.
        /// 
        ///  
        /// <para>
        /// Encrypted EBS volumes must be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After you attach an EBS volume, you must make it available. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-using-volumes.html">Make
        /// an EBS volume available for use</a>.
        /// </para>
        ///  
        /// <para>
        /// If a volume has an Amazon Web Services Marketplace product code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The volume can be attached only to a stopped instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Marketplace product codes are copied from the volume to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must be subscribed to the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance type and operating system of the instance must support the product. For
        /// example, you can't detach a volume from a Windows instance and attach it to a Linux
        /// instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attach
        /// an Amazon EBS volume to an instance</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachVpnGateway



        /// <summary>
        /// Attaches a virtual private gateway to a VPC. You can attach one virtual private gateway
        /// to one VPC at a time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeClientVpnIngress



        /// <summary>
        /// Adds an ingress authorization rule to a Client VPN endpoint. Ingress authorization
        /// rules act as firewall rules that grant access to networks. You must configure ingress
        /// authorization rules to enable clients to access resources in Amazon Web Services or
        /// on-premises networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClientVpnIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeClientVpnIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeClientVpnIngress">REST API Reference for AuthorizeClientVpnIngress Operation</seealso>
        Task<AuthorizeClientVpnIngressResponse> AuthorizeClientVpnIngressAsync(AuthorizeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeSecurityGroupEgress



        /// <summary>
        /// [VPC only] Adds the specified outbound (egress) rules to a security group for use
        /// with a VPC.
        /// 
        ///  
        /// <para>
        /// An outbound rule permits instances to send traffic to the specified IPv4 or IPv6 CIDR
        /// address ranges, or to the instances that are associated with the specified source
        /// security groups.
        /// </para>
        ///  
        /// <para>
        /// You specify a protocol for each rule (for example, TCP). For the TCP and UDP protocols,
        /// you must also specify the destination port or port range. For the ICMP protocol, you
        /// must also specify the ICMP type and code. You can use -1 for the type or code to mean
        /// all types or all codes.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to affected instances as quickly as possible. However,
        /// a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// For information about VPC security group quotas, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC quotas</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeSecurityGroupIngress



        /// <summary>
        /// Adds the specified inbound (ingress) rules to a security group.
        /// 
        ///  
        /// <para>
        /// An inbound rule permits instances to receive traffic from the specified IPv4 or IPv6
        /// CIDR address range, or from the instances that are associated with the specified destination
        /// security groups.
        /// </para>
        ///  
        /// <para>
        /// You specify a protocol for each rule (for example, TCP). For TCP and UDP, you must
        /// also specify the destination port or port range. For ICMP/ICMPv6, you must also specify
        /// the ICMP/ICMPv6 type and code. You can use -1 to mean all types or all codes.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPC security group quotas, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC quotas</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BundleInstance



        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// 
        ///  
        /// <para>
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance
        /// store volumes is not preserved.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not applicable for Linux/Unix instances or Windows instances that are
        /// backed by Amazon EBS.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelBundleTask



        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelCapacityReservation



        /// <summary>
        /// Cancels the specified Capacity Reservation, releases the reserved capacity, and changes
        /// the Capacity Reservation's state to <code>cancelled</code>.
        /// 
        ///  
        /// <para>
        /// Instances running in the reserved capacity continue running until you stop them. Stopped
        /// instances that target the Capacity Reservation can no longer launch. Modify these
        /// instances to either target a different Capacity Reservation, launch On-Demand Instance
        /// capacity, or run in any open Capacity Reservation that has matching attributes and
        /// sufficient capacity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelCapacityReservation">REST API Reference for CancelCapacityReservation Operation</seealso>
        Task<CancelCapacityReservationResponse> CancelCapacityReservationAsync(CancelCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelCapacityReservationFleets



        /// <summary>
        /// Cancels one or more Capacity Reservation Fleets. When you cancel a Capacity Reservation
        /// Fleet, the following happens:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Capacity Reservation Fleet's status changes to <code>cancelled</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The individual Capacity Reservations in the Fleet are cancelled. Instances running
        /// in the Capacity Reservations at the time of cancelling the Fleet continue to run in
        /// shared capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Fleet stops creating new Capacity Reservations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityReservationFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCapacityReservationFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelCapacityReservationFleets">REST API Reference for CancelCapacityReservationFleets Operation</seealso>
        Task<CancelCapacityReservationFleetsResponse> CancelCapacityReservationFleetsAsync(CancelCapacityReservationFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelConversionTask



        /// <summary>
        /// Cancels an active conversion task. The task can be the import of an instance or volume.
        /// The action removes all artifacts of the conversion, including a partially uploaded
        /// volume or instance. If the conversion is complete or is in the process of transferring
        /// the final disk image, the command fails and returns an exception.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelExportTask



        /// <summary>
        /// Cancels an active export task. The request removes all artifacts of the export, including
        /// any partially-created Amazon S3 objects. If the export task is complete or is in the
        /// process of transferring the final disk image, the command fails and returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelImportTask



        /// <summary>
        /// Cancels an in-process import virtual machine or import snapshot task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelReservedInstancesListing



        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSpotFleetRequests



        /// <summary>
        /// Cancels the specified Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// After you cancel a Spot Fleet request, the Spot Fleet launches no new Spot Instances.
        /// You must specify whether the Spot Fleet should also terminate its Spot Instances.
        /// If you terminate the instances, the Spot Fleet request enters the <code>cancelled_terminating</code>
        /// state. Otherwise, the Spot Fleet request enters the <code>cancelled_running</code>
        /// state and the instances continue to run until they are interrupted or you terminate
        /// them manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSpotInstanceRequests



        /// <summary>
        /// Cancels one or more Spot Instance requests.
        /// 
        ///  <important> 
        /// <para>
        /// Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfirmProductInstance



        /// <summary>
        /// Determines whether a product code is associated with an instance. This action can
        /// only be used by the owner of the product code. It is useful when a product code owner
        /// must verify whether another user's instance is eligible for support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyFpgaImage



        /// <summary>
        /// Copies the specified Amazon FPGA Image (AFI) to the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        Task<CopyFpgaImageResponse> CopyFpgaImageAsync(CopyFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyImage



        /// <summary>
        /// Initiates the copy of an AMI. You can copy an AMI from one Region to another, or from
        /// a Region to an Outpost. You can't copy an AMI from an Outpost to a Region, from one
        /// Outpost to another, or within the same Outpost. To copy an AMI to another partition,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateStoreImageTask.html">CreateStoreImageTask</a>.
        /// 
        ///  
        /// <para>
        /// To copy an AMI from one Region to another, specify the source Region using the <b>SourceRegion</b>
        /// parameter, and specify the destination Region using its endpoint. Copies of encrypted
        /// backing snapshots for the AMI are encrypted. Copies of unencrypted backing snapshots
        /// remain unencrypted, unless you set <code>Encrypted</code> during the copy operation.
        /// You cannot create an unencrypted copy of an encrypted backing snapshot.
        /// </para>
        ///  
        /// <para>
        /// To copy an AMI from a Region to an Outpost, specify the source Region using the <b>SourceRegion</b>
        /// parameter, and specify the ARN of the destination Outpost using <b>DestinationOutpostArn</b>.
        /// Backing snapshots copied to an Outpost are encrypted by default using the default
        /// encryption key for the Region, or a different key that you specify in the request
        /// using <b>KmsKeyId</b>. Outposts do not support unencrypted snapshots. For more information,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#ami">
        /// Amazon EBS local snapshots on Outposts</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the prerequisites and limits when copying an AMI, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying
        /// an AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopySnapshot



        /// <summary>
        /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
        /// copy a snapshot within the same Region, from one Region to another, or from a Region
        /// to an Outpost. You can't copy a snapshot from an Outpost to a Region, from one Outpost
        /// to another, or within the same Outpost.
        /// 
        ///  
        /// <para>
        /// You can use the snapshot to create EBS volumes or Amazon Machine Images (AMIs).
        /// </para>
        ///  
        /// <para>
        /// When copying snapshots to a Region, copies of encrypted EBS snapshots remain encrypted.
        /// Copies of unencrypted snapshots remain unencrypted, unless you enable encryption for
        /// the snapshot copy operation. By default, encrypted snapshot copies use the default
        /// Key Management Service (KMS) KMS key; however, you can specify a different KMS key.
        /// To copy an encrypted snapshot that has been shared from another account, you must
        /// have permissions for the KMS key used to encrypt the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots copied to an Outpost are encrypted by default using the default encryption
        /// key for the Region, or a different key that you specify in the request using <b>KmsKeyId</b>.
        /// Outposts do not support unencrypted snapshots. For more information, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#ami">
        /// Amazon EBS local snapshots on Outposts</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Snapshots created by copying another snapshot have an arbitrary volume ID that should
        /// not be used for any purpose.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copy
        /// an Amazon EBS snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCapacityReservation



        /// <summary>
        /// Creates a new Capacity Reservation with the specified attributes.
        /// 
        ///  
        /// <para>
        /// Capacity Reservations enable you to reserve capacity for your Amazon EC2 instances
        /// in a specific Availability Zone for any duration. This gives you the flexibility to
        /// selectively add capacity reservations and still get the Regional RI discounts for
        /// that usage. By creating Capacity Reservations, you ensure that you always have access
        /// to Amazon EC2 capacity when you need it, for as long as you need it. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-reservations.html">Capacity
        /// Reservations</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Your request to create a Capacity Reservation could fail if Amazon EC2 does not have
        /// sufficient capacity to fulfill the request. If your request fails due to Amazon EC2
        /// capacity constraints, either try again at a later time, try in a different Availability
        /// Zone, or request a smaller capacity reservation. If your application is flexible across
        /// instance types and sizes, try to create a Capacity Reservation with different instance
        /// attributes.
        /// </para>
        ///  
        /// <para>
        /// Your request could also fail if the requested quantity exceeds your On-Demand Instance
        /// limit for the selected instance type. If your request fails due to limit constraints,
        /// increase your On-Demand Instance limit for the required instance type and try again.
        /// For more information about increasing your instance limits, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-resource-limits.html">Amazon
        /// EC2 Service Quotas</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCapacityReservation">REST API Reference for CreateCapacityReservation Operation</seealso>
        Task<CreateCapacityReservationResponse> CreateCapacityReservationAsync(CreateCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCapacityReservationFleet



        /// <summary>
        /// Creates a Capacity Reservation Fleet. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-cr-fleets.html#create-crfleet">Create
        /// a Capacity Reservation Fleet</a> in the Amazon EC2 User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityReservationFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCapacityReservationFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCapacityReservationFleet">REST API Reference for CreateCapacityReservationFleet Operation</seealso>
        Task<CreateCapacityReservationFleetResponse> CreateCapacityReservationFleetAsync(CreateCapacityReservationFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCarrierGateway



        /// <summary>
        /// Creates a carrier gateway. For more information about carrier gateways, see <a href="https://docs.aws.amazon.com/wavelength/latest/developerguide/how-wavelengths-work.html#wavelength-carrier-gateway">Carrier
        /// gateways</a> in the <i>Amazon Web Services Wavelength Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCarrierGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCarrierGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCarrierGateway">REST API Reference for CreateCarrierGateway Operation</seealso>
        Task<CreateCarrierGatewayResponse> CreateCarrierGatewayAsync(CreateCarrierGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClientVpnEndpoint



        /// <summary>
        /// Creates a Client VPN endpoint. A Client VPN endpoint is the resource you create and
        /// configure to enable and manage client VPN sessions. It is the destination endpoint
        /// at which all client VPN sessions are terminated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnEndpoint">REST API Reference for CreateClientVpnEndpoint Operation</seealso>
        Task<CreateClientVpnEndpointResponse> CreateClientVpnEndpointAsync(CreateClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClientVpnRoute



        /// <summary>
        /// Adds a route to a network to a Client VPN endpoint. Each Client VPN endpoint has a
        /// route table that describes the available destination network routes. Each route in
        /// the route table specifies the path for traﬃc to speciﬁc resources or networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClientVpnRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnRoute">REST API Reference for CreateClientVpnRoute Operation</seealso>
        Task<CreateClientVpnRouteResponse> CreateClientVpnRouteAsync(CreateClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomerGateway



        /// <summary>
        /// Provides information to Amazon Web Services about your VPN customer gateway device.
        /// The customer gateway is the appliance at your end of the VPN connection. (The device
        /// on the Amazon Web Services side of the VPN connection is the virtual private gateway.)
        /// You must provide the internet-routable IP address of the customer gateway's external
        /// interface. The IP address must be static and can be behind a device performing network
        /// address translation (NAT).
        /// 
        ///  
        /// <para>
        /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
        /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
        /// range).
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 supports all 4-byte ASN numbers in the range of 1 - 2147483647, with the
        /// exception of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 7224 - reserved in the <code>us-east-1</code> Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 9059 - reserved in the <code>eu-west-1</code> Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 17943 - reserved in the <code>ap-southeast-1</code> Region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 10124 - reserved in the <code>ap-northeast-1</code> Region
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To create more than one customer gateway with the same VPN type, IP address, and BGP
        /// ASN, specify a unique device name for each customer gateway. Identical requests return
        /// information about the existing customer gateway and do not create new customer gateways.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDefaultSubnet



        /// <summary>
        /// Creates a default subnet with a size <code>/20</code> IPv4 CIDR block in the specified
        /// Availability Zone in your default VPC. You can have only one default subnet per Availability
        /// Zone. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/default-vpc.html#create-default-subnet">Creating
        /// a default subnet</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDefaultSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        Task<CreateDefaultSubnetResponse> CreateDefaultSubnetAsync(CreateDefaultSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDefaultVpc



        /// <summary>
        /// Creates a default VPC with a size <code>/16</code> IPv4 CIDR block and a default subnet
        /// in each Availability Zone. For more information about the components of a default
        /// VPC, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/default-vpc.html">Default
        /// VPC and default subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// You cannot specify the components of the default VPC yourself.
        /// 
        ///  
        /// <para>
        /// If you deleted your previous default VPC, you can create a default VPC. You cannot
        /// have more than one default VPC per Region.
        /// </para>
        ///  
        /// <para>
        /// If your account supports EC2-Classic, you cannot use this action to create a default
        /// VPC in a Region that supports EC2-Classic. If you want a default VPC in a Region that
        /// supports EC2-Classic, see "I really want a default VPC for my existing EC2 account.
        /// Is that possible?" in the <a href="http://aws.amazon.com/vpc/faqs/#Default_VPCs">Default
        /// VPCs FAQ</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDefaultVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        Task<CreateDefaultVpcResponse> CreateDefaultVpcAsync(CreateDefaultVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDhcpOptions



        /// <summary>
        /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
        /// it with the VPC, causing all existing and new instances that you launch in the VPC
        /// to use this set of DHCP options. The following are the individual DHCP options you
        /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>domain-name-servers</code> - The IP addresses of up to four domain name servers,
        /// or AmazonProvidedDNS. The default DHCP option set specifies AmazonProvidedDNS. If
        /// specifying more than one domain name server, specify the IP addresses in a single
        /// parameter, separated by commas. To have your instance receive a custom DNS hostname
        /// as specified in <code>domain-name</code>, you must set <code>domain-name-servers</code>
        /// to a custom DNS server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>domain-name</code> - If you're using AmazonProvidedDNS in <code>us-east-1</code>,
        /// specify <code>ec2.internal</code>. If you're using AmazonProvidedDNS in another Region,
        /// specify <code>region.compute.internal</code> (for example, <code>ap-northeast-1.compute.internal</code>).
        /// Otherwise, specify a domain name (for example, <code>ExampleCompany.com</code>). This
        /// value is used to complete unqualified DNS hostnames. <b>Important</b>: Some Linux
        /// operating systems accept multiple domain names separated by spaces. However, Windows
        /// and other Linux operating systems treat the value as a single domain, which results
        /// in unexpected behavior. If your DHCP options set is associated with a VPC that has
        /// instances with multiple operating systems, specify only one domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
        /// servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-name-servers</code> - The IP addresses of up to four NetBIOS name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-node-type</code> - The NetBIOS node type (1, 2, 4, or 8). We recommend
        /// that you specify 2 (broadcast and multicast are not currently supported). For more
        /// information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your VPC automatically starts out with a set of DHCP options that includes only a
        /// DNS server that we provide (AmazonProvidedDNS). If you create a set of options, and
        /// if your VPC has an internet gateway, make sure to set the <code>domain-name-servers</code>
        /// option either to <code>AmazonProvidedDNS</code> or to a domain name server of your
        /// choice. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
        /// options sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEgressOnlyInternetGateway



        /// <summary>
        /// [IPv6 only] Creates an egress-only internet gateway for your VPC. An egress-only internet
        /// gateway is used to enable outbound communication over IPv6 from instances in your
        /// VPC to the internet, and prevents hosts outside of your VPC from initiating an IPv6
        /// connection with your instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        Task<CreateEgressOnlyInternetGatewayResponse> CreateEgressOnlyInternetGatewayAsync(CreateEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFleet



        /// <summary>
        /// Launches an EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// You can create a single EC2 Fleet that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html">Launching
        /// an EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFlowLogs



        /// <summary>
        /// Creates one or more flow logs to capture information about IP traffic for a specific
        /// network interface, subnet, or VPC. 
        /// 
        ///  
        /// <para>
        /// Flow log data for a monitored network interface is recorded as flow log records, which
        /// are log events consisting of fields that describe the traffic flow. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-logs.html#flow-log-records">Flow
        /// log records</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When publishing to CloudWatch Logs, flow log records are published to a log group,
        /// and each network interface has a unique log stream in the log group. When publishing
        /// to Amazon S3, flow log records for all of the monitored network interfaces are published
        /// to a single log file object that is stored in the specified bucket.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/flow-logs.html">VPC
        /// Flow Logs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFpgaImage



        /// <summary>
        /// Creates an Amazon FPGA Image (AFI) from the specified design checkpoint (DCP).
        /// 
        ///  
        /// <para>
        /// The create operation is asynchronous. To verify that the AFI is ready for use, check
        /// the output logs.
        /// </para>
        ///  
        /// <para>
        /// An AFI contains the FPGA bitstream that is ready to download to an FPGA. You can securely
        /// deploy an AFI on multiple FPGA-accelerated instances. For more information, see the
        /// <a href="https://github.com/aws/aws-fpga/">Amazon Web Services FPGA Hardware Development
        /// Kit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        Task<CreateFpgaImageResponse> CreateFpgaImageAsync(CreateFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImage



        /// <summary>
        /// Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either
        /// running or stopped.
        /// 
        ///  
        /// <para>
        /// If you customized your instance with instance store volumes or Amazon EBS volumes
        /// in addition to the root device volume, the new AMI contains block device mapping information
        /// for those volumes. When you launch an instance from this new AMI, the instance automatically
        /// launches with those additional volumes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstanceEventWindow



        /// <summary>
        /// Creates an event window in which scheduled events for the associated Amazon EC2 instances
        /// can run.
        /// 
        ///  
        /// <para>
        /// You can define either a set of time ranges or a cron expression when creating the
        /// event window, but not both. All event window times are in UTC.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 200 event windows per Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// When you create the event window, targets (instance IDs, Dedicated Host IDs, or tags)
        /// are not yet associated with it. To ensure that the event window can be used, you must
        /// associate one or more targets with it by using the <a>AssociateInstanceEventWindow</a>
        /// API.
        /// </para>
        ///  <important> 
        /// <para>
        /// Event windows are applicable only for scheduled events that stop, reboot, or terminate
        /// instances.
        /// </para>
        ///  
        /// <para>
        /// Event windows are <i>not</i> applicable for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Expedited scheduled events and network maintenance events. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unscheduled maintenance such as AutoRecovery and unplanned reboots.
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceEventWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceEventWindow service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceEventWindow">REST API Reference for CreateInstanceEventWindow Operation</seealso>
        Task<CreateInstanceEventWindowResponse> CreateInstanceEventWindowAsync(CreateInstanceEventWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstanceExportTask



        /// <summary>
        /// Exports a running or stopped instance to an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// For information about the supported operating systems, image formats, and known limitations
        /// for the types of instances you can export, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html">Exporting
        /// an instance as a VM Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInternetGateway


        /// <summary>
        /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIpam



        /// <summary>
        /// Create an IPAM. Amazon VCP IP Address Manager (IPAM) is a VPC feature that you can
        /// use to automate your IP address management workflows including assigning, tracking,
        /// troubleshooting, and auditing IP addresses across Amazon Web Services Regions and
        /// accounts throughout your Amazon Web Services Organization.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/create-ipam.html">Create an IPAM</a>
        /// in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIpam service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateIpam">REST API Reference for CreateIpam Operation</seealso>
        Task<CreateIpamResponse> CreateIpamAsync(CreateIpamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIpamPool



        /// <summary>
        /// Create an IP address pool for Amazon VPC IP Address Manager (IPAM). In IPAM, a pool
        /// is a collection of contiguous IP addresses CIDRs. Pools enable you to organize your
        /// IP addresses according to your routing and security needs. For example, if you have
        /// separate routing and security needs for development and production applications, you
        /// can create a pool for each.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/create-top-ipam.html">Create a
        /// top-level pool</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpamPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIpamPool service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateIpamPool">REST API Reference for CreateIpamPool Operation</seealso>
        Task<CreateIpamPoolResponse> CreateIpamPoolAsync(CreateIpamPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIpamScope



        /// <summary>
        /// Create an IPAM scope. In IPAM, a scope is the highest-level container within IPAM.
        /// An IPAM contains two default scopes. Each scope represents the IP space for a single
        /// network. The private scope is intended for all private IP address space. The public
        /// scope is intended for all public IP address space. Scopes enable you to reuse IP addresses
        /// across multiple unconnected networks without causing IP address overlap or conflict.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/add-scope-ipam.html">Add a scope</a>
        /// in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpamScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIpamScope service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateIpamScope">REST API Reference for CreateIpamScope Operation</seealso>
        Task<CreateIpamScopeResponse> CreateIpamScopeAsync(CreateIpamScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKeyPair



        /// <summary>
        /// Creates an ED25519 or 2048-bit RSA key pair with the specified name. Amazon EC2 stores
        /// the public key and displays the private key for you to save to a file. The private
        /// key is returned as an unencrypted PEM encoded PKCS#1 private key. If a key with the
        /// specified name already exists, Amazon EC2 returns an error.
        /// 
        ///  
        /// <para>
        /// The key pair returned to you is available only in the Amazon Web Services Region in
        /// which you create it. If you prefer, you can create your own key pair using a third-party
        /// tool and upload it to any Region using <a>ImportKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 5,000 key pairs per Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLaunchTemplate



        /// <summary>
        /// Creates a launch template. A launch template contains the parameters to launch an
        /// instance. When you launch an instance using <a>RunInstances</a>, you can specify a
        /// launch template instead of providing the launch parameters in the request. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launching
        /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLaunchTemplateVersion



        /// <summary>
        /// Creates a new version for a launch template. You can specify an existing version of
        /// launch template from which to base the new version.
        /// 
        ///  
        /// <para>
        /// Launch template versions are numbered in the order in which they are created. You
        /// cannot specify, change, or replace the numbering of launch template versions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#manage-launch-template-versions">Managing
        /// launch template versions</a>in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchTemplateVersion service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionAsync(CreateLaunchTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLocalGatewayRoute



        /// <summary>
        /// Creates a static route for the specified local gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocalGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocalGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLocalGatewayRoute">REST API Reference for CreateLocalGatewayRoute Operation</seealso>
        Task<CreateLocalGatewayRouteResponse> CreateLocalGatewayRouteAsync(CreateLocalGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLocalGatewayRouteTableVpcAssociation



        /// <summary>
        /// Associates the specified VPC with the specified local gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocalGatewayRouteTableVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocalGatewayRouteTableVpcAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLocalGatewayRouteTableVpcAssociation">REST API Reference for CreateLocalGatewayRouteTableVpcAssociation Operation</seealso>
        Task<CreateLocalGatewayRouteTableVpcAssociationResponse> CreateLocalGatewayRouteTableVpcAssociationAsync(CreateLocalGatewayRouteTableVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateManagedPrefixList



        /// <summary>
        /// Creates a managed prefix list. You can specify one or more entries for the prefix
        /// list. Each entry consists of a CIDR block and an optional description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedPrefixList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateManagedPrefixList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateManagedPrefixList">REST API Reference for CreateManagedPrefixList Operation</seealso>
        Task<CreateManagedPrefixListResponse> CreateManagedPrefixListAsync(CreateManagedPrefixListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNatGateway



        /// <summary>
        /// Creates a NAT gateway in the specified subnet. This action creates a network interface
        /// in the specified subnet with a private IP address from the IP address range of the
        /// subnet. You can create either a public NAT gateway or a private NAT gateway.
        /// 
        ///  
        /// <para>
        /// With a public NAT gateway, internet-bound traffic from a private subnet can be routed
        /// to the NAT gateway, so that instances in a private subnet can connect to the internet.
        /// </para>
        ///  
        /// <para>
        /// With a private NAT gateway, private communication is routed across VPCs and on-premises
        /// networks through a transit gateway or virtual private gateway. Common use cases include
        /// running large workloads behind a small pool of allowlisted IPv4 addresses, preserving
        /// private IPv4 addresses, and communicating between overlapping networks.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-nat-gateway.html">NAT
        /// gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkAcl



        /// <summary>
        /// Creates a network ACL in a VPC. Network ACLs provide an optional layer of security
        /// (in addition to security groups) for the instances in your VPC.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkAclEntry



        /// <summary>
        /// Creates an entry (a rule) in a network ACL with the specified rule number. Each network
        /// ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated
        /// with the ACL, we process the entries in the ACL according to the rule numbers, in
        /// ascending order. Each network ACL has a set of ingress rules and a separate set of
        /// egress rules.
        /// 
        ///  
        /// <para>
        /// We recommend that you leave room between the rule numbers (for example, 100, 110,
        /// 120, ...), and not number them one right after the other (for example, 101, 102, 103,
        /// ...). This makes it easier to add a rule between existing ones without having to renumber
        /// the rules.
        /// </para>
        ///  
        /// <para>
        /// After you add an entry, you can't modify it; you must either replace it, or create
        /// an entry and delete the old one.
        /// </para>
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkInsightsAccessScope



        /// <summary>
        /// Creates a Network Access Scope.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Network Access Analyzer enables cloud networking and cloud operations
        /// teams to verify that their networks on Amazon Web Services conform to their network
        /// security and governance objectives. For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/network-access-analyzer/">Amazon
        /// Web Services Network Access Analyzer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInsightsAccessScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInsightsAccessScope service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInsightsAccessScope">REST API Reference for CreateNetworkInsightsAccessScope Operation</seealso>
        Task<CreateNetworkInsightsAccessScopeResponse> CreateNetworkInsightsAccessScopeAsync(CreateNetworkInsightsAccessScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkInsightsPath



        /// <summary>
        /// Creates a path to analyze for reachability.
        /// 
        ///  
        /// <para>
        /// Reachability Analyzer enables you to analyze and debug network reachability between
        /// two resources in your virtual private cloud (VPC). For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/reachability/">What
        /// is Reachability Analyzer</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInsightsPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInsightsPath service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInsightsPath">REST API Reference for CreateNetworkInsightsPath Operation</seealso>
        Task<CreateNetworkInsightsPathResponse> CreateNetworkInsightsPathAsync(CreateNetworkInsightsPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkInterface



        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// 
        ///  
        /// <para>
        /// For more information about network interfaces, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetworkInterfacePermission



        /// <summary>
        /// Grants an Amazon Web Services-authorized account permission to attach the specified
        /// network interface to an instance in their account.
        /// 
        ///  
        /// <para>
        /// You can grant permission to a single Amazon Web Services account only, and only one
        /// account at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionAsync(CreateNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePlacementGroup



        /// <summary>
        /// Creates a placement group in which to launch instances. The strategy of the placement
        /// group determines how the instances are organized within the group. 
        /// 
        ///  
        /// <para>
        /// A <code>cluster</code> placement group is a logical grouping of instances within a
        /// single Availability Zone that benefit from low network latency, high network throughput.
        /// A <code>spread</code> placement group places instances on distinct hardware. A <code>partition</code>
        /// placement group places groups of instances in different partitions, where instances
        /// in one partition do not share the same hardware with instances in another partition.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePublicIpv4Pool



        /// <summary>
        /// Creates a public IPv4 address pool. A public IPv4 pool is an EC2 IP address pool required
        /// for the public IPv4 CIDRs that you own and bring to Amazon Web Services to manage
        /// with IPAM. IPv6 addresses you bring to Amazon Web Services, however, use IPAM pools
        /// only. To monitor the status of pool creation, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribePublicIpv4Pools.html">DescribePublicIpv4Pools</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicIpv4Pool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePublicIpv4Pool service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePublicIpv4Pool">REST API Reference for CreatePublicIpv4Pool Operation</seealso>
        Task<CreatePublicIpv4PoolResponse> CreatePublicIpv4PoolAsync(CreatePublicIpv4PoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReplaceRootVolumeTask



        /// <summary>
        /// Creates a root volume replacement task for an Amazon EC2 instance. The root volume
        /// can either be restored to its initial launch state, or it can be restored using a
        /// specific snapshot.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-restoring-volume.html#replace-root">Replace
        /// a root volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplaceRootVolumeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplaceRootVolumeTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReplaceRootVolumeTask">REST API Reference for CreateReplaceRootVolumeTask Operation</seealso>
        Task<CreateReplaceRootVolumeTaskResponse> CreateReplaceRootVolumeTaskAsync(CreateReplaceRootVolumeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReservedInstancesListing



        /// <summary>
        /// Creates a listing for Amazon EC2 Standard Reserved Instances to be sold in the Reserved
        /// Instance Marketplace. You can submit one Standard Reserved Instance listing at a time.
        /// To get a list of your Standard Reserved Instances, you can use the <a>DescribeReservedInstances</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Only Standard Reserved Instances can be sold in the Reserved Instance Marketplace.
        /// Convertible Reserved Instances cannot be sold.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Standard Reserved
        /// Instance capacity that they no longer need with buyers who want to purchase additional
        /// capacity. Reserved Instances bought and sold through the Reserved Instance Marketplace
        /// work like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// To sell your Standard Reserved Instances, you must first register as a seller in the
        /// Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Standard Reserved
        /// Instances, and specify the upfront price to receive for them. Your Standard Reserved
        /// Instance listings then become available for purchase. To view the details of your
        /// Standard Reserved Instance listing, you can use the <a>DescribeReservedInstancesListings</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRestoreImageTask



        /// <summary>
        /// Starts a task that restores an AMI from an Amazon S3 object that was previously created
        /// by using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateStoreImageTask.html">CreateStoreImageTask</a>.
        /// 
        ///  
        /// <para>
        /// To use this API, you must have the required permissions. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
        /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
        /// and restore an AMI using Amazon S3</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreImageTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRestoreImageTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRestoreImageTask">REST API Reference for CreateRestoreImageTask Operation</seealso>
        Task<CreateRestoreImageTaskResponse> CreateRestoreImageTaskAsync(CreateRestoreImageTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoute



        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: internet gateway or virtual private
        /// gateway, NAT instance, NAT gateway, VPC peering connection, network interface, egress-only
        /// internet gateway, or transit gateway.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, traffic is destined for the IPv4 address <code>192.0.2.3</code>, and
        /// the route table includes the following two IPv4 routes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>192.0.2.0/24</code> (goes to some target A)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>192.0.2.0/28</code> (goes to some target B)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both routes apply to the traffic destined for <code>192.0.2.3</code>. However, the
        /// second route in the list covers a smaller number of IP addresses and is therefore
        /// more specific, so we use that route to determine where to target the traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRouteTable



        /// <summary>
        /// Creates a route table for the specified VPC. After you create a route table, you can
        /// add routes and associate the table with a subnet.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityGroup



        /// <summary>
        /// Creates a security group.
        /// 
        ///  
        /// <para>
        /// A security group acts as a virtual firewall for your instance to control inbound and
        /// outbound traffic. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 security groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// groups for your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security
        /// group for use in a VPC. However, you can't have two security groups for use in EC2-Classic
        /// with the same name or two security groups for use in a VPC with the same name.
        /// </para>
        ///  
        /// <para>
        /// You have a default security group for use in EC2-Classic and a default security group
        /// for use in your VPC. If you don't specify a security group when you launch an instance,
        /// the instance is launched into the appropriate default security group. A default security
        /// group includes a default rule that grants instances unrestricted network access to
        /// each other.
        /// </para>
        ///  
        /// <para>
        /// You can add or remove rules from your security groups using <a>AuthorizeSecurityGroupIngress</a>,
        /// <a>AuthorizeSecurityGroupEgress</a>, <a>RevokeSecurityGroupIngress</a>, and <a>RevokeSecurityGroupEgress</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPC security group limits, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshot



        /// <summary>
        /// Creates a snapshot of an EBS volume and stores it in Amazon S3. You can use snapshots
        /// for backups, to make copies of EBS volumes, and to save data before shutting down
        /// an instance.
        /// 
        ///  
        /// <para>
        /// You can create snapshots of volumes in a Region and volumes on an Outpost. If you
        /// create a snapshot of a volume in a Region, the snapshot must be stored in the same
        /// Region as the volume. If you create a snapshot of a volume on an Outpost, the snapshot
        /// can be stored on the same Outpost as the volume, or in the Region for that Outpost.
        /// </para>
        ///  
        /// <para>
        /// When a snapshot is created, any Amazon Web Services Marketplace product codes that
        /// are associated with the source volume are propagated to the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can take a snapshot of an attached volume that is in use. However, snapshots only
        /// capture data that has been written to your Amazon EBS volume at the time the snapshot
        /// command is issued; this might exclude any data that has been cached by any applications
        /// or the operating system. If you can pause any file systems on the volume long enough
        /// to take a snapshot, your snapshot should be complete. However, if you cannot pause
        /// all file writes to the volume, you should unmount the volume from within the instance,
        /// issue the snapshot command, and then remount the volume to ensure a consistent and
        /// complete snapshot. You may remount and use your volume while the snapshot status is
        /// <code>pending</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a snapshot for Amazon EBS volumes that serve as root devices, you should
        /// stop the instance before taking the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
        /// volumes and any associated snapshots always remain protected.
        /// </para>
        ///  
        /// <para>
        /// You can tag your snapshots during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
        /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
        /// Elastic Block Store</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshots



        /// <summary>
        /// Creates crash-consistent snapshots of multiple EBS volumes and stores the data in
        /// S3. Volumes are chosen by specifying an instance. Any attached volumes will produce
        /// one snapshot each that is crash-consistent across the instance. Boot volumes can be
        /// excluded by changing the parameters. 
        /// 
        ///  
        /// <para>
        /// You can create multi-volume snapshots of instances in a Region and instances on an
        /// Outpost. If you create snapshots from an instance in a Region, the snapshots must
        /// be stored in the same Region as the instance. If you create snapshots from an instance
        /// on an Outpost, the snapshots can be stored on the same Outpost as the instance, or
        /// in the Region for that Outpost.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshots">REST API Reference for CreateSnapshots Operation</seealso>
        Task<CreateSnapshotsResponse> CreateSnapshotsAsync(CreateSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSpotDatafeedSubscription



        /// <summary>
        /// Creates a data feed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance data feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStoreImageTask



        /// <summary>
        /// Stores an AMI as a single object in an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// To use this API, you must have the required permissions. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
        /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
        /// and restore an AMI using Amazon S3</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStoreImageTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStoreImageTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateStoreImageTask">REST API Reference for CreateStoreImageTask Operation</seealso>
        Task<CreateStoreImageTaskResponse> CreateStoreImageTaskAsync(CreateStoreImageTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubnet



        /// <summary>
        /// Creates a subnet in a specified VPC.
        /// 
        ///  
        /// <para>
        /// You must specify an IPv4 CIDR block for the subnet. After you create a subnet, you
        /// can't change its CIDR block. The allowed block size is between a /16 netmask (65,536
        /// IP addresses) and /28 netmask (16 IP addresses). The CIDR block must not overlap with
        /// the CIDR block of an existing subnet in the VPC.
        /// </para>
        ///  
        /// <para>
        /// If you've associated an IPv6 CIDR block with your VPC, you can create a subnet with
        /// an IPv6 CIDR block that uses a /64 prefix length. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Web Services reserves both the first four and the last IPv4 address in each
        /// subnet's CIDR block. They're not available for use.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you add more than one subnet to a VPC, they're set up in a star topology with a
        /// logical router in the middle.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance in a subnet, it retains its private IPv4 address. It's therefore
        /// possible to have a subnet with no running instances (they're all stopped), but no
        /// remaining IP addresses available.
        /// </para>
        ///  
        /// <para>
        /// For more information about subnets, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">Your
        /// VPC and subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubnetCidrReservation



        /// <summary>
        /// Creates a subnet CIDR reservation. For information about subnet CIDR reservations,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/subnet-cidr-reservation.html">Subnet
        /// CIDR reservations</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetCidrReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubnetCidrReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnetCidrReservation">REST API Reference for CreateSubnetCidrReservation Operation</seealso>
        Task<CreateSubnetCidrReservationResponse> CreateSubnetCidrReservationAsync(CreateSubnetCidrReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Amazon EC2 resource or
        /// resources. When you specify an existing tag key, the value is overwritten with the
        /// new value. Each resource can have a maximum of 50 tags. Each tag consists of a key
        /// and optional value. Tag keys must be unique per resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more
        /// information about creating IAM policies that control users' access to resources based
        /// on tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-iam-actions-resources.html">Supported
        /// Resource-Level Permissions for Amazon EC2 API Actions</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficMirrorFilter



        /// <summary>
        /// Creates a Traffic Mirror filter.
        /// 
        ///  
        /// <para>
        /// A Traffic Mirror filter is a set of rules that defines the traffic to mirror.
        /// </para>
        ///  
        /// <para>
        /// By default, no traffic is mirrored. To mirror traffic, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorFilterRule.htm">CreateTrafficMirrorFilterRule</a>
        /// to add Traffic Mirror rules to the filter. The rules you add define what traffic gets
        /// mirrored. You can also use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyTrafficMirrorFilterNetworkServices.html">ModifyTrafficMirrorFilterNetworkServices</a>
        /// to mirror supported network services.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficMirrorFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficMirrorFilter service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTrafficMirrorFilter">REST API Reference for CreateTrafficMirrorFilter Operation</seealso>
        Task<CreateTrafficMirrorFilterResponse> CreateTrafficMirrorFilterAsync(CreateTrafficMirrorFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficMirrorFilterRule



        /// <summary>
        /// Creates a Traffic Mirror filter rule.
        /// 
        ///  
        /// <para>
        /// A Traffic Mirror rule defines the Traffic Mirror source traffic to mirror.
        /// </para>
        ///  
        /// <para>
        /// You need the Traffic Mirror filter ID when you create the rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficMirrorFilterRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficMirrorFilterRule service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTrafficMirrorFilterRule">REST API Reference for CreateTrafficMirrorFilterRule Operation</seealso>
        Task<CreateTrafficMirrorFilterRuleResponse> CreateTrafficMirrorFilterRuleAsync(CreateTrafficMirrorFilterRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficMirrorSession



        /// <summary>
        /// Creates a Traffic Mirror session.
        /// 
        ///  
        /// <para>
        /// A Traffic Mirror session actively copies packets from a Traffic Mirror source to a
        /// Traffic Mirror target. Create a filter, and then assign it to the session to define
        /// a subset of the traffic to mirror, for example all TCP traffic.
        /// </para>
        ///  
        /// <para>
        /// The Traffic Mirror source and the Traffic Mirror target (monitoring appliances) can
        /// be in the same VPC, or in a different VPC connected via VPC peering or a transit gateway.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, no traffic is mirrored. Use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorFilter.htm">CreateTrafficMirrorFilter</a>
        /// to create filter rules that specify the traffic to mirror.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficMirrorSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficMirrorSession service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTrafficMirrorSession">REST API Reference for CreateTrafficMirrorSession Operation</seealso>
        Task<CreateTrafficMirrorSessionResponse> CreateTrafficMirrorSessionAsync(CreateTrafficMirrorSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficMirrorTarget



        /// <summary>
        /// Creates a target for your Traffic Mirror session.
        /// 
        ///  
        /// <para>
        /// A Traffic Mirror target is the destination for mirrored traffic. The Traffic Mirror
        /// source and the Traffic Mirror target (monitoring appliances) can be in the same VPC,
        /// or in different VPCs connected via VPC peering or a transit gateway.
        /// </para>
        ///  
        /// <para>
        /// A Traffic Mirror target can be a network interface, or a Network Load Balancer.
        /// </para>
        ///  
        /// <para>
        /// To use the target in a Traffic Mirror session, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorSession.htm">CreateTrafficMirrorSession</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficMirrorTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficMirrorTarget service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTrafficMirrorTarget">REST API Reference for CreateTrafficMirrorTarget Operation</seealso>
        Task<CreateTrafficMirrorTargetResponse> CreateTrafficMirrorTargetAsync(CreateTrafficMirrorTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGateway



        /// <summary>
        /// Creates a transit gateway.
        /// 
        ///  
        /// <para>
        /// You can use a transit gateway to interconnect your virtual private clouds (VPC) and
        /// on-premises networks. After the transit gateway enters the <code>available</code>
        /// state, you can attach your VPCs and VPN connections to the transit gateway.
        /// </para>
        ///  
        /// <para>
        /// To attach your VPCs, use <a>CreateTransitGatewayVpcAttachment</a>.
        /// </para>
        ///  
        /// <para>
        /// To attach a VPN connection, use <a>CreateCustomerGateway</a> to create a customer
        /// gateway and specify the ID of the customer gateway and the ID of the transit gateway
        /// in a call to <a>CreateVpnConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create a transit gateway, we create a default transit gateway route table
        /// and use it as the default association route table and the default propagation route
        /// table. You can use <a>CreateTransitGatewayRouteTable</a> to create additional transit
        /// gateway route tables. If you disable automatic route propagation, we do not create
        /// a default transit gateway route table. You can use <a>EnableTransitGatewayRouteTablePropagation</a>
        /// to propagate routes from a resource attachment to a transit gateway route table. If
        /// you disable automatic associations, you can use <a>AssociateTransitGatewayRouteTable</a>
        /// to associate a resource attachment with a transit gateway route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGateway">REST API Reference for CreateTransitGateway Operation</seealso>
        Task<CreateTransitGatewayResponse> CreateTransitGatewayAsync(CreateTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayConnect



        /// <summary>
        /// Creates a Connect attachment from a specified transit gateway attachment. A Connect
        /// attachment is a GRE-based tunnel attachment that you can use to establish a connection
        /// between a transit gateway and an appliance.
        /// 
        ///  
        /// <para>
        /// A Connect attachment uses an existing VPC or Amazon Web Services Direct Connect attachment
        /// as the underlying transport mechanism.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayConnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayConnect service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayConnect">REST API Reference for CreateTransitGatewayConnect Operation</seealso>
        Task<CreateTransitGatewayConnectResponse> CreateTransitGatewayConnectAsync(CreateTransitGatewayConnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayConnectPeer



        /// <summary>
        /// Creates a Connect peer for a specified transit gateway Connect attachment between
        /// a transit gateway and an appliance.
        /// 
        ///  
        /// <para>
        /// The peer address and transit gateway address must be the same IP address family (IPv4
        /// or IPv6).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-connect.html#tgw-connect-peer">Connect
        /// peers</a> in the <i>Transit Gateways Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayConnectPeer service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayConnectPeer">REST API Reference for CreateTransitGatewayConnectPeer Operation</seealso>
        Task<CreateTransitGatewayConnectPeerResponse> CreateTransitGatewayConnectPeerAsync(CreateTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayMulticastDomain



        /// <summary>
        /// Creates a multicast domain using the specified transit gateway.
        /// 
        ///  
        /// <para>
        /// The transit gateway must be in the available state before you create a domain. Use
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeTransitGateways.html">DescribeTransitGateways</a>
        /// to see the state of transit gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayMulticastDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayMulticastDomain service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayMulticastDomain">REST API Reference for CreateTransitGatewayMulticastDomain Operation</seealso>
        Task<CreateTransitGatewayMulticastDomainResponse> CreateTransitGatewayMulticastDomainAsync(CreateTransitGatewayMulticastDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayPeeringAttachment



        /// <summary>
        /// Requests a transit gateway peering attachment between the specified transit gateway
        /// (requester) and a peer transit gateway (accepter). The transit gateways must be in
        /// different Regions. The peer transit gateway can be in your account or a different
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// After you create the peering attachment, the owner of the accepter transit gateway
        /// must accept the attachment request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeeringAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayPeeringAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayPeeringAttachment">REST API Reference for CreateTransitGatewayPeeringAttachment Operation</seealso>
        Task<CreateTransitGatewayPeeringAttachmentResponse> CreateTransitGatewayPeeringAttachmentAsync(CreateTransitGatewayPeeringAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayPrefixListReference



        /// <summary>
        /// Creates a reference (route) to a prefix list in a specified transit gateway route
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPrefixListReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayPrefixListReference service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayPrefixListReference">REST API Reference for CreateTransitGatewayPrefixListReference Operation</seealso>
        Task<CreateTransitGatewayPrefixListReferenceResponse> CreateTransitGatewayPrefixListReferenceAsync(CreateTransitGatewayPrefixListReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayRoute



        /// <summary>
        /// Creates a static route for the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRoute">REST API Reference for CreateTransitGatewayRoute Operation</seealso>
        Task<CreateTransitGatewayRouteResponse> CreateTransitGatewayRouteAsync(CreateTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayRouteTable



        /// <summary>
        /// Creates a route table for the specified transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRouteTable">REST API Reference for CreateTransitGatewayRouteTable Operation</seealso>
        Task<CreateTransitGatewayRouteTableResponse> CreateTransitGatewayRouteTableAsync(CreateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransitGatewayVpcAttachment



        /// <summary>
        /// Attaches the specified VPC to the specified transit gateway.
        /// 
        ///  
        /// <para>
        /// If you attach a VPC with a CIDR range that overlaps the CIDR range of a VPC that is
        /// already attached, the new VPC CIDR range is not propagated to the default propagation
        /// route table.
        /// </para>
        ///  
        /// <para>
        /// To send VPC traffic to an attached transit gateway, add a route to the VPC route table
        /// using <a>CreateRoute</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayVpcAttachment">REST API Reference for CreateTransitGatewayVpcAttachment Operation</seealso>
        Task<CreateTransitGatewayVpcAttachmentResponse> CreateTransitGatewayVpcAttachmentAsync(CreateTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVolume



        /// <summary>
        /// Creates an EBS volume that can be attached to an instance in the same Availability
        /// Zone.
        /// 
        ///  
        /// <para>
        /// You can create a new empty volume or restore a volume from an EBS snapshot. Any Amazon
        /// Web Services Marketplace product codes from the snapshot are propagated to the volume.
        /// </para>
        ///  
        /// <para>
        /// You can create encrypted volumes. Encrypted volumes must be attached to instances
        /// that support Amazon EBS encryption. Volumes that are created from encrypted snapshots
        /// are also automatically encrypted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can tag your volumes during creation. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
        /// your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Create
        /// an Amazon EBS volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpc



        /// <summary>
        /// Creates a VPC with the specified IPv4 CIDR block. The smallest VPC you can create
        /// uses a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536
        /// IPv4 addresses). For more information about how large to make your VPC, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">Your
        /// VPC and subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can optionally request an IPv6 CIDR block for the VPC. You can request an Amazon-provided
        /// IPv6 CIDR block from Amazon's pool of IPv6 addresses, or an IPv6 CIDR block from an
        /// IPv6 address pool that you provisioned through bring your own IP addresses (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">BYOIP</a>).
        /// </para>
        ///  
        /// <para>
        /// By default, each instance you launch in the VPC has the default DHCP options, which
        /// include only a default DNS server that we provide (AmazonProvidedDNS). For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
        /// options sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the instance tenancy value for the VPC when you create it. You can't
        /// change this value for the VPC after you create it. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcEndpoint



        /// <summary>
        /// Creates a VPC endpoint for a specified service. An endpoint enables you to create
        /// a private connection between your VPC and the service. The service may be provided
        /// by Amazon Web Services, an Amazon Web Services Marketplace Partner, or another Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// A <code>gateway</code> endpoint serves as a target for a route in your route table
        /// for traffic destined for the Amazon Web Service. You can specify an endpoint policy
        /// to attach to the endpoint, which will control access to the service from your VPC.
        /// You can also specify the VPC route tables that use the endpoint.
        /// </para>
        ///  
        /// <para>
        /// An <code>interface</code> endpoint is a network interface in your subnet that serves
        /// as an endpoint for communicating with the specified service. You can specify the subnets
        /// in which to create an endpoint, and the security groups to associate with the endpoint
        /// network interface.
        /// </para>
        ///  
        /// <para>
        /// A <code>GatewayLoadBalancer</code> endpoint is a network interface in your subnet
        /// that serves an endpoint for communicating with a Gateway Load Balancer that you've
        /// configured as a VPC endpoint service.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DescribeVpcEndpointServices</a> to get a list of supported services.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcEndpointConnectionNotification



        /// <summary>
        /// Creates a connection notification for a specified VPC endpoint or VPC endpoint service.
        /// A connection notification notifies you of specific endpoint events. You must create
        /// an SNS topic to receive notifications. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Create
        /// a Topic</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create a connection notification for interface endpoints only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        Task<CreateVpcEndpointConnectionNotificationResponse> CreateVpcEndpointConnectionNotificationAsync(CreateVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcEndpointServiceConfiguration



        /// <summary>
        /// Creates a VPC endpoint service configuration to which service consumers (Amazon Web
        /// Services accounts, IAM users, and IAM roles) can connect.
        /// 
        ///  
        /// <para>
        /// To create an endpoint service configuration, you must first create one of the following
        /// for your service:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/introduction.html">Network
        /// Load Balancer</a>. Service consumers connect to your service using an interface endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/introduction.html">Gateway
        /// Load Balancer</a>. Service consumers connect to your service using a Gateway Load
        /// Balancer endpoint.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-service.html">VPC
        /// Endpoint Services</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you set the private DNS name, you must prove that you own the private DNS domain
        /// name. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-services-dns-validation.html">VPC
        /// Endpoint Service Private DNS Name Verification</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        Task<CreateVpcEndpointServiceConfigurationResponse> CreateVpcEndpointServiceConfigurationAsync(CreateVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcPeeringConnection



        /// <summary>
        /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
        /// an accepter VPC with which to create the connection. The accepter VPC can belong to
        /// another Amazon Web Services account and can be in a different Region to the requester
        /// VPC. The requester VPC and accepter VPC cannot have overlapping CIDR blocks.
        /// 
        ///  <note> 
        /// <para>
        /// Limitations and rules apply to a VPC peering connection. For more information, see
        /// the <a href="https://docs.aws.amazon.com/vpc/latest/peering/vpc-peering-basics.html#vpc-peering-limitations">limitations</a>
        /// section in the <i>VPC Peering Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The owner of the accepter VPC must accept the peering request to activate the peering
        /// connection. The VPC peering connection request expires after 7 days, after which it
        /// cannot be accepted or rejected.
        /// </para>
        ///  
        /// <para>
        /// If you create a VPC peering connection request between VPCs with overlapping CIDR
        /// blocks, the VPC peering connection has a status of <code>failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnConnection



        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway or transit gateway
        /// and a customer gateway. The supported connection type is <code>ipsec.1</code>.
        /// 
        ///  
        /// <para>
        /// The response includes information that you need to give to your network administrator
        /// to configure your customer gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway
        /// device.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you decide to shut down your VPN connection for any reason and later create a new
        /// VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnConnectionRoute



        /// <summary>
        /// Creates a static route associated with a VPN connection between an existing virtual
        /// private gateway and a VPN customer gateway. The static route allows traffic to be
        /// routed from the virtual private gateway to the VPN customer gateway.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpnGateway



        /// <summary>
        /// Creates a virtual private gateway. A virtual private gateway is the endpoint on the
        /// VPC side of your VPN connection. You can create a virtual private gateway before creating
        /// the VPC itself.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCarrierGateway



        /// <summary>
        /// Deletes a carrier gateway.
        /// 
        ///  <important> 
        /// <para>
        /// If you do not delete the route that contains the carrier gateway as the Target, the
        /// route is a blackhole route. For information about how to delete a route, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteRoute.html">DeleteRoute</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCarrierGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCarrierGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCarrierGateway">REST API Reference for DeleteCarrierGateway Operation</seealso>
        Task<DeleteCarrierGatewayResponse> DeleteCarrierGatewayAsync(DeleteCarrierGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClientVpnEndpoint



        /// <summary>
        /// Deletes the specified Client VPN endpoint. You must disassociate all target networks
        /// before you can delete a Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnEndpoint">REST API Reference for DeleteClientVpnEndpoint Operation</seealso>
        Task<DeleteClientVpnEndpointResponse> DeleteClientVpnEndpointAsync(DeleteClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClientVpnRoute



        /// <summary>
        /// Deletes a route from a Client VPN endpoint. You can only delete routes that you manually
        /// added using the <b>CreateClientVpnRoute</b> action. You cannot delete routes that
        /// were automatically added when associating a subnet. To remove routes that have been
        /// automatically added, disassociate the target subnet from the Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClientVpnRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnRoute">REST API Reference for DeleteClientVpnRoute Operation</seealso>
        Task<DeleteClientVpnRouteResponse> DeleteClientVpnRouteAsync(DeleteClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomerGateway



        /// <summary>
        /// Deletes the specified customer gateway. You must delete the VPN connection before
        /// you can delete the customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDhcpOptions



        /// <summary>
        /// Deletes the specified set of DHCP options. You must disassociate the set of DHCP options
        /// before you can delete it. You can disassociate the set of DHCP options by associating
        /// either a new set of options or the default set of options with the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEgressOnlyInternetGateway



        /// <summary>
        /// Deletes an egress-only internet gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        Task<DeleteEgressOnlyInternetGatewayResponse> DeleteEgressOnlyInternetGatewayAsync(DeleteEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFleets



        /// <summary>
        /// Deletes the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// After you delete an EC2 Fleet, it launches no new instances.
        /// </para>
        ///  
        /// <para>
        /// You must specify whether a deleted EC2 Fleet should also terminate its instances.
        /// If you choose to terminate the instances, the EC2 Fleet enters the <code>deleted_terminating</code>
        /// state. Otherwise, the EC2 Fleet enters the <code>deleted_running</code> state, and
        /// the instances continue to run until they are interrupted or you terminate them manually.
        /// </para>
        ///  
        /// <para>
        /// For <code>instant</code> fleets, EC2 Fleet must terminate the instances when the fleet
        /// is deleted. A deleted <code>instant</code> fleet with running instances is not supported.
        /// </para>
        ///  <p class="title"> <b>Restrictions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can delete up to 25 <code>instant</code> fleets in a single request. If you exceed
        /// this number, no <code>instant</code> fleets are deleted and an error is returned.
        /// There is no restriction on the number of fleets of type <code>maintain</code> or <code>request</code>
        /// that can be deleted in a single request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Up to 1000 instances can be terminated in a single request to delete <code>instant</code>
        /// fleets.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-ec2-fleet.html#delete-fleet">Deleting
        /// an EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        Task<DeleteFleetsResponse> DeleteFleetsAsync(DeleteFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFlowLogs



        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFpgaImage



        /// <summary>
        /// Deletes the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        Task<DeleteFpgaImageResponse> DeleteFpgaImageAsync(DeleteFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInstanceEventWindow



        /// <summary>
        /// Deletes the specified event window.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceEventWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstanceEventWindow service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInstanceEventWindow">REST API Reference for DeleteInstanceEventWindow Operation</seealso>
        Task<DeleteInstanceEventWindowResponse> DeleteInstanceEventWindowAsync(DeleteInstanceEventWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInternetGateway



        /// <summary>
        /// Deletes the specified internet gateway. You must detach the internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIpam



        /// <summary>
        /// Delete an IPAM. Deleting an IPAM removes all monitored data associated with the IPAM
        /// including the historical data for CIDRs.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an IPAM if there are CIDRs provisioned to pools or if there are
        /// allocations in the pools within the IPAM. To deprovision pool CIDRs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeprovisionIpamPoolCidr.html">DeprovisionIpamPoolCidr</a>.
        /// To release allocations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ReleaseIpamPoolAllocation.html">ReleaseIpamPoolAllocation</a>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/delete-ipam.html">Delete an IPAM</a>
        /// in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIpam service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteIpam">REST API Reference for DeleteIpam Operation</seealso>
        Task<DeleteIpamResponse> DeleteIpamAsync(DeleteIpamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIpamPool



        /// <summary>
        /// Delete an IPAM pool.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an IPAM pool if there are allocations in it or CIDRs provisioned
        /// to it. To release allocations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ReleaseIpamPoolAllocation.html">ReleaseIpamPoolAllocation</a>.
        /// To deprovision pool CIDRs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeprovisionIpamPoolCidr.html">DeprovisionIpamPoolCidr</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/delete-pool-ipam.html">Delete
        /// a pool</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpamPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIpamPool service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteIpamPool">REST API Reference for DeleteIpamPool Operation</seealso>
        Task<DeleteIpamPoolResponse> DeleteIpamPoolAsync(DeleteIpamPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIpamScope



        /// <summary>
        /// Delete the scope for an IPAM. You cannot delete the default scopes.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/delete-scope-ipam.html">Delete
        /// a scope</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpamScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIpamScope service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteIpamScope">REST API Reference for DeleteIpamScope Operation</seealso>
        Task<DeleteIpamScopeResponse> DeleteIpamScopeAsync(DeleteIpamScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteKeyPair



        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLaunchTemplate



        /// <summary>
        /// Deletes a launch template. Deleting a launch template deletes all of its versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateAsync(DeleteLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLaunchTemplateVersions



        /// <summary>
        /// Deletes one or more versions of a launch template. You cannot delete the default version
        /// of a launch template; you must first assign a different version as the default. If
        /// the default version is the only version for the launch template, you must delete the
        /// entire launch template using <a>DeleteLaunchTemplate</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        Task<DeleteLaunchTemplateVersionsResponse> DeleteLaunchTemplateVersionsAsync(DeleteLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLocalGatewayRoute



        /// <summary>
        /// Deletes the specified route from the specified local gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocalGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocalGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLocalGatewayRoute">REST API Reference for DeleteLocalGatewayRoute Operation</seealso>
        Task<DeleteLocalGatewayRouteResponse> DeleteLocalGatewayRouteAsync(DeleteLocalGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLocalGatewayRouteTableVpcAssociation



        /// <summary>
        /// Deletes the specified association between a VPC and local gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocalGatewayRouteTableVpcAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocalGatewayRouteTableVpcAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLocalGatewayRouteTableVpcAssociation">REST API Reference for DeleteLocalGatewayRouteTableVpcAssociation Operation</seealso>
        Task<DeleteLocalGatewayRouteTableVpcAssociationResponse> DeleteLocalGatewayRouteTableVpcAssociationAsync(DeleteLocalGatewayRouteTableVpcAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteManagedPrefixList



        /// <summary>
        /// Deletes the specified managed prefix list. You must first remove all references to
        /// the prefix list in your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedPrefixList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteManagedPrefixList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteManagedPrefixList">REST API Reference for DeleteManagedPrefixList Operation</seealso>
        Task<DeleteManagedPrefixListResponse> DeleteManagedPrefixListAsync(DeleteManagedPrefixListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNatGateway



        /// <summary>
        /// Deletes the specified NAT gateway. Deleting a public NAT gateway disassociates its
        /// Elastic IP address, but does not release the address from your account. Deleting a
        /// NAT gateway does not delete any NAT gateway routes in your route tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkAcl



        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkAclEntry



        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInsightsAccessScope



        /// <summary>
        /// Deletes the specified Network Access Scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInsightsAccessScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInsightsAccessScope service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInsightsAccessScope">REST API Reference for DeleteNetworkInsightsAccessScope Operation</seealso>
        Task<DeleteNetworkInsightsAccessScopeResponse> DeleteNetworkInsightsAccessScopeAsync(DeleteNetworkInsightsAccessScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInsightsAccessScopeAnalysis



        /// <summary>
        /// Deletes the specified Network Access Scope analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInsightsAccessScopeAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInsightsAccessScopeAnalysis service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInsightsAccessScopeAnalysis">REST API Reference for DeleteNetworkInsightsAccessScopeAnalysis Operation</seealso>
        Task<DeleteNetworkInsightsAccessScopeAnalysisResponse> DeleteNetworkInsightsAccessScopeAnalysisAsync(DeleteNetworkInsightsAccessScopeAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInsightsAnalysis



        /// <summary>
        /// Deletes the specified network insights analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInsightsAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInsightsAnalysis service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInsightsAnalysis">REST API Reference for DeleteNetworkInsightsAnalysis Operation</seealso>
        Task<DeleteNetworkInsightsAnalysisResponse> DeleteNetworkInsightsAnalysisAsync(DeleteNetworkInsightsAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInsightsPath



        /// <summary>
        /// Deletes the specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInsightsPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInsightsPath service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInsightsPath">REST API Reference for DeleteNetworkInsightsPath Operation</seealso>
        Task<DeleteNetworkInsightsPathResponse> DeleteNetworkInsightsPathAsync(DeleteNetworkInsightsPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInterface



        /// <summary>
        /// Deletes the specified network interface. You must detach the network interface before
        /// you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNetworkInterfacePermission



        /// <summary>
        /// Deletes a permission for a network interface. By default, you cannot delete the permission
        /// if the account for which you're removing the permission has attached the network interface
        /// to an instance. However, you can force delete the permission, regardless of any attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionAsync(DeleteNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePlacementGroup



        /// <summary>
        /// Deletes the specified placement group. You must terminate all instances in the placement
        /// group before you can delete the placement group. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePublicIpv4Pool



        /// <summary>
        /// Delete a public IPv4 pool. A public IPv4 pool is an EC2 IP address pool required for
        /// the public IPv4 CIDRs that you own and bring to Amazon Web Services to manage with
        /// IPAM. IPv6 addresses you bring to Amazon Web Services, however, use IPAM pools only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicIpv4Pool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePublicIpv4Pool service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePublicIpv4Pool">REST API Reference for DeletePublicIpv4Pool Operation</seealso>
        Task<DeletePublicIpv4PoolResponse> DeletePublicIpv4PoolAsync(DeletePublicIpv4PoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueuedReservedInstances



        /// <summary>
        /// Deletes the queued purchases for the specified Reserved Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueuedReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteQueuedReservedInstances">REST API Reference for DeleteQueuedReservedInstances Operation</seealso>
        Task<DeleteQueuedReservedInstancesResponse> DeleteQueuedReservedInstancesAsync(DeleteQueuedReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoute



        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRouteTable



        /// <summary>
        /// Deletes the specified route table. You must disassociate the route table from any
        /// subnets before you can delete it. You can't delete the main route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityGroup



        /// <summary>
        /// Deletes a security group.
        /// 
        ///  
        /// <para>
        /// If you attempt to delete a security group that is associated with an instance, or
        /// is referenced by another security group, the operation fails with <code>InvalidGroup.InUse</code>
        /// in EC2-Classic or <code>DependencyViolation</code> in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshot



        /// <summary>
        /// Deletes the specified snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a volume, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the volume.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a snapshot of the root device of an EBS volume used by a registered
        /// AMI. You must first de-register the AMI before you can delete the snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html">Delete
        /// an Amazon EBS snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSpotDatafeedSubscription


        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubnet



        /// <summary>
        /// Deletes the specified subnet. You must terminate all running instances in the subnet
        /// before you can delete the subnet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubnetCidrReservation



        /// <summary>
        /// Deletes a subnet CIDR reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetCidrReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubnetCidrReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnetCidrReservation">REST API Reference for DeleteSubnetCidrReservation Operation</seealso>
        Task<DeleteSubnetCidrReservationResponse> DeleteSubnetCidrReservationAsync(DeleteSubnetCidrReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags



        /// <summary>
        /// Deletes the specified set of tags from the specified set of resources.
        /// 
        ///  
        /// <para>
        /// To list the current tags, use <a>DescribeTags</a>. For more information about tags,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficMirrorFilter



        /// <summary>
        /// Deletes the specified Traffic Mirror filter.
        /// 
        ///  
        /// <para>
        /// You cannot delete a Traffic Mirror filter that is in use by a Traffic Mirror session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficMirrorFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficMirrorFilter service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTrafficMirrorFilter">REST API Reference for DeleteTrafficMirrorFilter Operation</seealso>
        Task<DeleteTrafficMirrorFilterResponse> DeleteTrafficMirrorFilterAsync(DeleteTrafficMirrorFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficMirrorFilterRule



        /// <summary>
        /// Deletes the specified Traffic Mirror rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficMirrorFilterRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficMirrorFilterRule service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTrafficMirrorFilterRule">REST API Reference for DeleteTrafficMirrorFilterRule Operation</seealso>
        Task<DeleteTrafficMirrorFilterRuleResponse> DeleteTrafficMirrorFilterRuleAsync(DeleteTrafficMirrorFilterRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficMirrorSession



        /// <summary>
        /// Deletes the specified Traffic Mirror session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficMirrorSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficMirrorSession service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTrafficMirrorSession">REST API Reference for DeleteTrafficMirrorSession Operation</seealso>
        Task<DeleteTrafficMirrorSessionResponse> DeleteTrafficMirrorSessionAsync(DeleteTrafficMirrorSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficMirrorTarget



        /// <summary>
        /// Deletes the specified Traffic Mirror target.
        /// 
        ///  
        /// <para>
        /// You cannot delete a Traffic Mirror target that is in use by a Traffic Mirror session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficMirrorTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficMirrorTarget service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTrafficMirrorTarget">REST API Reference for DeleteTrafficMirrorTarget Operation</seealso>
        Task<DeleteTrafficMirrorTargetResponse> DeleteTrafficMirrorTargetAsync(DeleteTrafficMirrorTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGateway



        /// <summary>
        /// Deletes the specified transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGateway">REST API Reference for DeleteTransitGateway Operation</seealso>
        Task<DeleteTransitGatewayResponse> DeleteTransitGatewayAsync(DeleteTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayConnect



        /// <summary>
        /// Deletes the specified Connect attachment. You must first delete any Connect peers
        /// for the attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayConnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayConnect service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayConnect">REST API Reference for DeleteTransitGatewayConnect Operation</seealso>
        Task<DeleteTransitGatewayConnectResponse> DeleteTransitGatewayConnectAsync(DeleteTransitGatewayConnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayConnectPeer



        /// <summary>
        /// Deletes the specified Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayConnectPeer service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayConnectPeer">REST API Reference for DeleteTransitGatewayConnectPeer Operation</seealso>
        Task<DeleteTransitGatewayConnectPeerResponse> DeleteTransitGatewayConnectPeerAsync(DeleteTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayMulticastDomain



        /// <summary>
        /// Deletes the specified transit gateway multicast domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayMulticastDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayMulticastDomain service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayMulticastDomain">REST API Reference for DeleteTransitGatewayMulticastDomain Operation</seealso>
        Task<DeleteTransitGatewayMulticastDomainResponse> DeleteTransitGatewayMulticastDomainAsync(DeleteTransitGatewayMulticastDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayPeeringAttachment



        /// <summary>
        /// Deletes a transit gateway peering attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayPeeringAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayPeeringAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayPeeringAttachment">REST API Reference for DeleteTransitGatewayPeeringAttachment Operation</seealso>
        Task<DeleteTransitGatewayPeeringAttachmentResponse> DeleteTransitGatewayPeeringAttachmentAsync(DeleteTransitGatewayPeeringAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayPrefixListReference



        /// <summary>
        /// Deletes a reference (route) to a prefix list in a specified transit gateway route
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayPrefixListReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayPrefixListReference service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayPrefixListReference">REST API Reference for DeleteTransitGatewayPrefixListReference Operation</seealso>
        Task<DeleteTransitGatewayPrefixListReferenceResponse> DeleteTransitGatewayPrefixListReferenceAsync(DeleteTransitGatewayPrefixListReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayRoute



        /// <summary>
        /// Deletes the specified route from the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRoute">REST API Reference for DeleteTransitGatewayRoute Operation</seealso>
        Task<DeleteTransitGatewayRouteResponse> DeleteTransitGatewayRouteAsync(DeleteTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayRouteTable



        /// <summary>
        /// Deletes the specified transit gateway route table. You must disassociate the route
        /// table from any transit gateway route tables before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRouteTable">REST API Reference for DeleteTransitGatewayRouteTable Operation</seealso>
        Task<DeleteTransitGatewayRouteTableResponse> DeleteTransitGatewayRouteTableAsync(DeleteTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTransitGatewayVpcAttachment



        /// <summary>
        /// Deletes the specified VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayVpcAttachment">REST API Reference for DeleteTransitGatewayVpcAttachment Operation</seealso>
        Task<DeleteTransitGatewayVpcAttachmentResponse> DeleteTransitGatewayVpcAttachmentAsync(DeleteTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVolume



        /// <summary>
        /// Deletes the specified EBS volume. The volume must be in the <code>available</code>
        /// state (not attached to an instance).
        /// 
        ///  
        /// <para>
        /// The volume can remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Delete
        /// an Amazon EBS volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpc



        /// <summary>
        /// Deletes the specified VPC. You must detach or delete all gateways and resources that
        /// are associated with the VPC before you can delete it. For example, you must terminate
        /// all instances running in the VPC, delete all security groups associated with the VPC
        /// (except the default one), delete all route tables associated with the VPC (except
        /// the default one), and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcEndpointConnectionNotifications



        /// <summary>
        /// Deletes one or more VPC endpoint connection notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        Task<DeleteVpcEndpointConnectionNotificationsResponse> DeleteVpcEndpointConnectionNotificationsAsync(DeleteVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcEndpoints



        /// <summary>
        /// Deletes one or more specified VPC endpoints. You can delete any of the following types
        /// of VPC endpoints. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Gateway endpoint,
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Gateway Load Balancer endpoint,
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Interface endpoint
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following rules apply when you delete a VPC endpoint:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you delete a gateway endpoint, we delete the endpoint routes in the route tables
        /// that are associated with the endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you delete a Gateway Load Balancer endpoint, we delete the endpoint network interfaces.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can only delete Gateway Load Balancer endpoints when the routes that are associated
        /// with the endpoint are deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you delete an interface endpoint, we delete the endpoint network interfaces.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcEndpointServiceConfigurations



        /// <summary>
        /// Deletes one or more VPC endpoint service configurations in your account. Before you
        /// delete the endpoint service configuration, you must reject any <code>Available</code>
        /// or <code>PendingAcceptance</code> interface endpoint connections that are attached
        /// to the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        Task<DeleteVpcEndpointServiceConfigurationsResponse> DeleteVpcEndpointServiceConfigurationsAsync(DeleteVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcPeeringConnection



        /// <summary>
        /// Deletes a VPC peering connection. Either the owner of the requester VPC or the owner
        /// of the accepter VPC can delete the VPC peering connection if it's in the <code>active</code>
        /// state. The owner of the requester VPC can delete a VPC peering connection in the <code>pending-acceptance</code>
        /// state. You cannot delete a VPC peering connection that's in the <code>failed</code>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnConnection



        /// <summary>
        /// Deletes the specified VPN connection.
        /// 
        ///  
        /// <para>
        /// If you're deleting the VPC and its associated components, we recommend that you detach
        /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
        /// connection. If you believe that the tunnel credentials for your VPN connection have
        /// been compromised, you can delete the VPN connection and create a new one that has
        /// new keys, without needing to delete the VPC or virtual private gateway. If you create
        /// a new VPN connection, you must reconfigure the customer gateway device using the new
        /// configuration information returned with the new VPN connection ID.
        /// </para>
        ///  
        /// <para>
        /// For certificate-based authentication, delete all Certificate Manager (ACM) private
        /// certificates used for the Amazon Web Services-side tunnel endpoints for the VPN connection
        /// before deleting the VPN connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnConnectionRoute



        /// <summary>
        /// Deletes the specified static route associated with a VPN connection between an existing
        /// virtual private gateway and a VPN customer gateway. The static route allows traffic
        /// to be routed from the virtual private gateway to the VPN customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpnGateway



        /// <summary>
        /// Deletes the specified virtual private gateway. You must first detach the virtual private
        /// gateway from the VPC. Note that you don't need to delete the virtual private gateway
        /// if you plan to delete and recreate the VPN connection between your VPC and your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprovisionByoipCidr



        /// <summary>
        /// Releases the specified address range that you provisioned for use with your Amazon
        /// Web Services resources through bring your own IP addresses (BYOIP) and deletes the
        /// corresponding address pool.
        /// 
        ///  
        /// <para>
        /// Before you can release an address range, you must stop advertising it using <a>WithdrawByoipCidr</a>
        /// and you must not have any IP addresses allocated from its address range.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprovisionByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        Task<DeprovisionByoipCidrResponse> DeprovisionByoipCidrAsync(DeprovisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprovisionIpamPoolCidr



        /// <summary>
        /// Deprovision a CIDR provisioned from an IPAM pool. If you deprovision a CIDR from a
        /// pool that has a source pool, the CIDR is recycled back into the source pool. For more
        /// information, see <a href="/vpc/latest/ipam/depro-pool-cidr-ipam.html">Deprovision
        /// pool CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionIpamPoolCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprovisionIpamPoolCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeprovisionIpamPoolCidr">REST API Reference for DeprovisionIpamPoolCidr Operation</seealso>
        Task<DeprovisionIpamPoolCidrResponse> DeprovisionIpamPoolCidrAsync(DeprovisionIpamPoolCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprovisionPublicIpv4PoolCidr



        /// <summary>
        /// Deprovision a CIDR from a public IPv4 pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionPublicIpv4PoolCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprovisionPublicIpv4PoolCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeprovisionPublicIpv4PoolCidr">REST API Reference for DeprovisionPublicIpv4PoolCidr Operation</seealso>
        Task<DeprovisionPublicIpv4PoolCidrResponse> DeprovisionPublicIpv4PoolCidrAsync(DeprovisionPublicIpv4PoolCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterImage



        /// <summary>
        /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
        /// new instances; however, it doesn't affect any instances that you've already launched
        /// from the AMI. You'll continue to incur usage costs for those instances until you terminate
        /// them.
        /// 
        ///  
        /// <para>
        /// When you deregister an Amazon EBS-backed AMI, it doesn't affect the snapshot that
        /// was created for the root volume of the instance during the AMI creation process. When
        /// you deregister an instance store-backed AMI, it doesn't affect the files that you
        /// uploaded to Amazon S3 when you created the AMI.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterInstanceEventNotificationAttributes



        /// <summary>
        /// c
        /// 
        ///  
        /// <para>
        /// Deregisters tag keys to prevent tags that have the specified tag keys from being included
        /// in scheduled event notifications for resources in the Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstanceEventNotificationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterInstanceEventNotificationAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterInstanceEventNotificationAttributes">REST API Reference for DeregisterInstanceEventNotificationAttributes Operation</seealso>
        Task<DeregisterInstanceEventNotificationAttributesResponse> DeregisterInstanceEventNotificationAttributesAsync(DeregisterInstanceEventNotificationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterTransitGatewayMulticastGroupMembers



        /// <summary>
        /// Deregisters the specified members (network interfaces) from the transit gateway multicast
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGatewayMulticastGroupMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTransitGatewayMulticastGroupMembers service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterTransitGatewayMulticastGroupMembers">REST API Reference for DeregisterTransitGatewayMulticastGroupMembers Operation</seealso>
        Task<DeregisterTransitGatewayMulticastGroupMembersResponse> DeregisterTransitGatewayMulticastGroupMembersAsync(DeregisterTransitGatewayMulticastGroupMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterTransitGatewayMulticastGroupSources



        /// <summary>
        /// Deregisters the specified sources (network interfaces) from the transit gateway multicast
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGatewayMulticastGroupSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTransitGatewayMulticastGroupSources service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterTransitGatewayMulticastGroupSources">REST API Reference for DeregisterTransitGatewayMulticastGroupSources Operation</seealso>
        Task<DeregisterTransitGatewayMulticastGroupSourcesResponse> DeregisterTransitGatewayMulticastGroupSourcesAsync(DeregisterTransitGatewayMulticastGroupSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountAttributes


        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: This attribute is no longer supported. The returned value
        /// does not reflect your actual vCPU limit for running On-Demand Instances. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-on-demand-instances.html#ec2-on-demand-instances-limits">On-Demand
        /// Instance Limits</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: This attribute is no longer supported. The returned value
        /// does not reflect your actual vCPU limit for running On-Demand Instances. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-on-demand-instances.html#ec2-on-demand-instances-limits">On-Demand
        /// Instance Limits</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAddresses


        /// <summary>
        /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        Task<DescribeAddressesResponse> DescribeAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAddressesAttribute



        /// <summary>
        /// Describes the attributes of the specified Elastic IP addresses. For requirements,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html#Using_Elastic_Addressing_Reverse_DNS">Using
        /// reverse DNS for email applications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddressesAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddressesAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddressesAttribute">REST API Reference for DescribeAddressesAttribute Operation</seealso>
        Task<DescribeAddressesAttributeResponse> DescribeAddressesAttributeAsync(DescribeAddressesAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAggregateIdFormat



        /// <summary>
        /// Describes the longer ID format settings for all resource types in a specific Region.
        /// This request is useful for performing a quick audit to determine whether a specific
        /// Region is fully opted in for longer IDs (17-character IDs).
        /// 
        ///  
        /// <para>
        /// This request only returns information about resource types that support longer IDs.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAggregateIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        Task<DescribeAggregateIdFormatResponse> DescribeAggregateIdFormatAsync(DescribeAggregateIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAvailabilityZones


        /// <summary>
        /// Describes the Availability Zones, Local Zones, and Wavelength Zones that are available
        /// to you. If there is an event impacting a zone, you can use this request to view the
        /// state and any provided messages for that zone.
        /// 
        ///  
        /// <para>
        /// For more information about Availability Zones, Local Zones, and Wavelength Zones,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the Availability Zones, Local Zones, and Wavelength Zones that are available
        /// to you. If there is an event impacting a zone, you can use this request to view the
        /// state and any provided messages for that zone.
        /// 
        ///  
        /// <para>
        /// For more information about Availability Zones, Local Zones, and Wavelength Zones,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBundleTasks


        /// <summary>
        /// Describes the specified bundle tasks or all of your bundle tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified bundle tasks or all of your bundle tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeByoipCidrs



        /// <summary>
        /// Describes the IP address ranges that were specified in calls to <a>ProvisionByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// To describe the address pools that were created when you provisioned the address ranges,
        /// use <a>DescribePublicIpv4Pools</a> or <a>DescribeIpv6Pools</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeByoipCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeByoipCidrs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeByoipCidrs">REST API Reference for DescribeByoipCidrs Operation</seealso>
        Task<DescribeByoipCidrsResponse> DescribeByoipCidrsAsync(DescribeByoipCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCapacityReservationFleets



        /// <summary>
        /// Describes one or more Capacity Reservation Fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservationFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCapacityReservationFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCapacityReservationFleets">REST API Reference for DescribeCapacityReservationFleets Operation</seealso>
        Task<DescribeCapacityReservationFleetsResponse> DescribeCapacityReservationFleetsAsync(DescribeCapacityReservationFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCapacityReservations



        /// <summary>
        /// Describes one or more of your Capacity Reservations. The results describe only the
        /// Capacity Reservations in the Amazon Web Services Region that you're currently using.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCapacityReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCapacityReservations">REST API Reference for DescribeCapacityReservations Operation</seealso>
        Task<DescribeCapacityReservationsResponse> DescribeCapacityReservationsAsync(DescribeCapacityReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCarrierGateways



        /// <summary>
        /// Describes one or more of your carrier gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCarrierGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCarrierGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCarrierGateways">REST API Reference for DescribeCarrierGateways Operation</seealso>
        Task<DescribeCarrierGatewaysResponse> DescribeCarrierGatewaysAsync(DescribeCarrierGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClassicLinkInstances



        /// <summary>
        /// Describes one or more of your linked EC2-Classic instances. This request only returns
        /// information about EC2-Classic instances linked to a VPC through ClassicLink. You cannot
        /// use this request to return information about other instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClassicLinkInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientVpnAuthorizationRules



        /// <summary>
        /// Describes the authorization rules for a specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnAuthorizationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnAuthorizationRules service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnAuthorizationRules">REST API Reference for DescribeClientVpnAuthorizationRules Operation</seealso>
        Task<DescribeClientVpnAuthorizationRulesResponse> DescribeClientVpnAuthorizationRulesAsync(DescribeClientVpnAuthorizationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientVpnConnections



        /// <summary>
        /// Describes active client connections and connections that have been terminated within
        /// the last 60 minutes for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnConnections">REST API Reference for DescribeClientVpnConnections Operation</seealso>
        Task<DescribeClientVpnConnectionsResponse> DescribeClientVpnConnectionsAsync(DescribeClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientVpnEndpoints



        /// <summary>
        /// Describes one or more Client VPN endpoints in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnEndpoints">REST API Reference for DescribeClientVpnEndpoints Operation</seealso>
        Task<DescribeClientVpnEndpointsResponse> DescribeClientVpnEndpointsAsync(DescribeClientVpnEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientVpnRoutes



        /// <summary>
        /// Describes the routes for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnRoutes">REST API Reference for DescribeClientVpnRoutes Operation</seealso>
        Task<DescribeClientVpnRoutesResponse> DescribeClientVpnRoutesAsync(DescribeClientVpnRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientVpnTargetNetworks



        /// <summary>
        /// Describes the target networks associated with the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnTargetNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClientVpnTargetNetworks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnTargetNetworks">REST API Reference for DescribeClientVpnTargetNetworks Operation</seealso>
        Task<DescribeClientVpnTargetNetworksResponse> DescribeClientVpnTargetNetworksAsync(DescribeClientVpnTargetNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCoipPools



        /// <summary>
        /// Describes the specified customer-owned address pools or all of your customer-owned
        /// address pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCoipPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCoipPools service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCoipPools">REST API Reference for DescribeCoipPools Operation</seealso>
        Task<DescribeCoipPoolsResponse> DescribeCoipPoolsAsync(DescribeCoipPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConversionTasks


        /// <summary>
        /// Describes the specified conversion tasks or all your conversion tasks. For more information,
        /// see the <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/">VM Import/Export
        /// User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified conversion tasks or all your conversion tasks. For more information,
        /// see the <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/">VM Import/Export
        /// User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomerGateways


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDhcpOptions


        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
        /// options sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
        /// options sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEgressOnlyInternetGateways



        /// <summary>
        /// Describes one or more of your egress-only internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEgressOnlyInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        Task<DescribeEgressOnlyInternetGatewaysResponse> DescribeEgressOnlyInternetGatewaysAsync(DescribeEgressOnlyInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeElasticGpus



        /// <summary>
        /// Describes the Elastic Graphics accelerator associated with your instances. For more
        /// information about Elastic Graphics, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-graphics.html">Amazon
        /// Elastic Graphics</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticGpus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        Task<DescribeElasticGpusResponse> DescribeElasticGpusAsync(DescribeElasticGpusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportImageTasks



        /// <summary>
        /// Describes the specified export image tasks or all of your export image tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportImageTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportImageTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportImageTasks">REST API Reference for DescribeExportImageTasks Operation</seealso>
        Task<DescribeExportImageTasksResponse> DescribeExportImageTasksAsync(DescribeExportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportTasks


        /// <summary>
        /// Describes the specified export instance tasks or all of your export instance tasks.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified export instance tasks or all of your export instance tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFastSnapshotRestores



        /// <summary>
        /// Describes the state of fast snapshot restores for your snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFastSnapshotRestores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFastSnapshotRestores service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFastSnapshotRestores">REST API Reference for DescribeFastSnapshotRestores Operation</seealso>
        Task<DescribeFastSnapshotRestoresResponse> DescribeFastSnapshotRestoresAsync(DescribeFastSnapshotRestoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetHistory



        /// <summary>
        /// Describes the events for the specified EC2 Fleet during the specified time.
        /// 
        ///  
        /// <para>
        /// EC2 Fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// EC2 Fleet events are available for 48 hours.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/fleet-monitor.html">Monitor
        /// fleet events using Amazon EventBridge</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        Task<DescribeFleetHistoryResponse> DescribeFleetHistoryAsync(DescribeFleetHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleetInstances



        /// <summary>
        /// Describes the running instances for the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html#monitor-ec2-fleet">Monitoring
        /// your EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        Task<DescribeFleetInstancesResponse> DescribeFleetInstancesAsync(DescribeFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFleets



        /// <summary>
        /// Describes the specified EC2 Fleets or all of your EC2 Fleets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html#monitor-ec2-fleet">Monitoring
        /// your EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFlowLogs



        /// <summary>
        /// Describes one or more flow logs. To view the information in your flow logs (the log
        /// streams for the network interfaces), you must use the CloudWatch Logs console or the
        /// CloudWatch Logs API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFpgaImageAttribute



        /// <summary>
        /// Describes the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        Task<DescribeFpgaImageAttributeResponse> DescribeFpgaImageAttributeAsync(DescribeFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFpgaImages



        /// <summary>
        /// Describes the Amazon FPGA Images (AFIs) available to you. These include public AFIs,
        /// private AFIs that you own, and AFIs owned by other Amazon Web Services accounts for
        /// which you have load permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFpgaImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        Task<DescribeFpgaImagesResponse> DescribeFpgaImagesAsync(DescribeFpgaImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHostReservationOfferings



        /// <summary>
        /// Describes the Dedicated Host reservations that are available to purchase.
        /// 
        ///  
        /// <para>
        /// The results describe all of the Dedicated Host reservation offerings, including offerings
        /// that might not match the instance family and Region of your Dedicated Hosts. When
        /// purchasing an offering, ensure that the instance family and Region of the offering
        /// matches that of the Dedicated Hosts with which it is to be associated. For more information
        /// about supported instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Hosts</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostReservationOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        Task<DescribeHostReservationOfferingsResponse> DescribeHostReservationOfferingsAsync(DescribeHostReservationOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHostReservations



        /// <summary>
        /// Describes reservations that are associated with Dedicated Hosts in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        Task<DescribeHostReservationsResponse> DescribeHostReservationsAsync(DescribeHostReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHosts



        /// <summary>
        /// Describes the specified Dedicated Hosts or all your Dedicated Hosts.
        /// 
        ///  
        /// <para>
        /// The results describe only the Dedicated Hosts in the Region you're currently using.
        /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
        /// have recently been released are listed with the state <code>released</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIamInstanceProfileAssociations



        /// <summary>
        /// Describes your IAM instance profile associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIamInstanceProfileAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        Task<DescribeIamInstanceProfileAssociationsResponse> DescribeIamInstanceProfileAssociationsAsync(DescribeIamInstanceProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIdentityIdFormat



        /// <summary>
        /// Describes the ID format settings for resources for the specified IAM user, IAM role,
        /// or root user. For example, you can view the resource types that are enabled for longer
        /// IDs. This request only returns information about resource types whose ID formats can
        /// be modified; it does not return information about other resource types. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the principal specified in the request. They do not apply
        /// to the principal that makes the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        Task<DescribeIdentityIdFormatResponse> DescribeIdentityIdFormatAsync(DescribeIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIdFormat



        /// <summary>
        /// Describes the ID format settings for your resources on a per-Region basis, for example,
        /// to view which resource types are enabled for longer IDs. This request only returns
        /// information about resource types whose ID formats can be modified; it does not return
        /// information about other resource types.
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the IAM user who makes the request; they do not apply to the
        /// entire Amazon Web Services account. By default, an IAM user defaults to the same settings
        /// as the root user, unless they explicitly override the settings by running the <a>ModifyIdFormat</a>
        /// command. Resources created with longer IDs are visible to all IAM users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        Task<DescribeIdFormatResponse> DescribeIdFormatAsync(DescribeIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageAttribute



        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImages


        /// <summary>
        /// Describes the specified images (AMIs, AKIs, and ARIs) available to you or all of the
        /// images available to you.
        /// 
        ///  
        /// <para>
        /// The images available to you include public images, private images that you own, and
        /// private images owned by other Amazon Web Services accounts for which you have explicit
        /// launch permissions.
        /// </para>
        ///  
        /// <para>
        /// Recently deregistered images appear in the returned results for a short interval and
        /// then return empty results. After all instances that reference a deregistered AMI are
        /// terminated, specifying the ID of the image will eventually return an error indicating
        /// that the AMI ID cannot be found.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        Task<DescribeImagesResponse> DescribeImagesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified images (AMIs, AKIs, and ARIs) available to you or all of the
        /// images available to you.
        /// 
        ///  
        /// <para>
        /// The images available to you include public images, private images that you own, and
        /// private images owned by other Amazon Web Services accounts for which you have explicit
        /// launch permissions.
        /// </para>
        ///  
        /// <para>
        /// Recently deregistered images appear in the returned results for a short interval and
        /// then return empty results. After all instances that reference a deregistered AMI are
        /// terminated, specifying the ID of the image will eventually return an error indicating
        /// that the AMI ID cannot be found.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImportImageTasks



        /// <summary>
        /// Displays details about an import virtual machine or import snapshot tasks that are
        /// already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImportImageTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImportSnapshotTasks



        /// <summary>
        /// Describes your import snapshot tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImportSnapshotTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceAttribute



        /// <summary>
        /// Describes the specified attribute of the specified instance. You can specify only
        /// one attribute at a time. Valid attribute values are: <code>instanceType</code> | <code>kernel</code>
        /// | <code>ramdisk</code> | <code>userData</code> | <code>disableApiTermination</code>
        /// | <code>instanceInitiatedShutdownBehavior</code> | <code>rootDeviceName</code> | <code>blockDeviceMapping</code>
        /// | <code>productCodes</code> | <code>sourceDestCheck</code> | <code>groupSet</code>
        /// | <code>ebsOptimized</code> | <code>sriovNetSupport</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceCreditSpecifications



        /// <summary>
        /// Describes the credit option for CPU usage of the specified burstable performance instances.
        /// The credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify an instance ID, Amazon EC2 returns burstable performance instances
        /// with the <code>unlimited</code> credit option, as well as instances that were previously
        /// configured as T2, T3, and T3a with the <code>unlimited</code> credit option. For example,
        /// if you resize a T2 instance, while it is configured as <code>unlimited</code>, to
        /// an M4 instance, Amazon EC2 returns the M4 instance.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns the credit option (<code>standard</code>
        /// or <code>unlimited</code>) of those instances. If you specify an instance ID that
        /// is not valid, such as an instance that is not a burstable performance instance, an
        /// error is returned.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If an Availability Zone is experiencing a service disruption and you specify instance
        /// IDs in the affected zone, or do not specify any instance IDs at all, the call fails.
        /// If you specify only instance IDs in an unaffected zone, the call works normally.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceCreditSpecifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        Task<DescribeInstanceCreditSpecificationsResponse> DescribeInstanceCreditSpecificationsAsync(DescribeInstanceCreditSpecificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceEventNotificationAttributes



        /// <summary>
        /// Describes the tag keys that are registered to appear in scheduled event notifications
        /// for resources in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceEventNotificationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceEventNotificationAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceEventNotificationAttributes">REST API Reference for DescribeInstanceEventNotificationAttributes Operation</seealso>
        Task<DescribeInstanceEventNotificationAttributesResponse> DescribeInstanceEventNotificationAttributesAsync(DescribeInstanceEventNotificationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceEventWindows



        /// <summary>
        /// Describes the specified event windows or all event windows.
        /// 
        ///  
        /// <para>
        /// If you specify event window IDs, the output includes information for only the specified
        /// event windows. If you specify filters, the output includes information for only those
        /// event windows that meet the filter criteria. If you do not specify event windows IDs
        /// or filters, the output includes information for all event windows, which can affect
        /// performance. We recommend that you use pagination to ensure that the operation returns
        /// quickly and successfully. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceEventWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceEventWindows service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceEventWindows">REST API Reference for DescribeInstanceEventWindows Operation</seealso>
        Task<DescribeInstanceEventWindowsResponse> DescribeInstanceEventWindowsAsync(DescribeInstanceEventWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstances


        /// <summary>
        /// Describes the specified instances or all instances.
        /// 
        ///  
        /// <para>
        /// If you specify instance IDs, the output includes information for only the specified
        /// instances. If you specify filters, the output includes information for only those
        /// instances that meet the filter criteria. If you do not specify instance IDs or filters,
        /// the output includes information for all instances, which can affect performance. We
        /// recommend that you use pagination to ensure that the operation returns quickly and
        /// successfully.
        /// </para>
        ///  
        /// <para>
        /// If you specify an instance ID that is not valid, an error is returned. If you specify
        /// an instance that you do not own, it is not included in the output.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified instances or all instances.
        /// 
        ///  
        /// <para>
        /// If you specify instance IDs, the output includes information for only the specified
        /// instances. If you specify filters, the output includes information for only those
        /// instances that meet the filter criteria. If you do not specify instance IDs or filters,
        /// the output includes information for all instances, which can affect performance. We
        /// recommend that you use pagination to ensure that the operation returns quickly and
        /// successfully.
        /// </para>
        ///  
        /// <para>
        /// If you specify an instance ID that is not valid, an error is returned. If you specify
        /// an instance that you do not own, it is not included in the output.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceStatus


        /// <summary>
        /// Describes the status of the specified instances or all of your instances. By default,
        /// only running instances are described, unless you specifically indicate to return the
        /// status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// checks for your instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshoot
        /// instances with failed status checks</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// events for your instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the status of the specified instances or all of your instances. By default,
        /// only running instances are described, unless you specifically indicate to return the
        /// status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// checks for your instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshoot
        /// instances with failed status checks</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// events for your instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceTypeOfferings



        /// <summary>
        /// Returns a list of all instance types offered. The results can be filtered by location
        /// (Region or Availability Zone). If no location is specified, the instance types offered
        /// in the current Region are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypeOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceTypeOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceTypeOfferings">REST API Reference for DescribeInstanceTypeOfferings Operation</seealso>
        Task<DescribeInstanceTypeOfferingsResponse> DescribeInstanceTypeOfferingsAsync(DescribeInstanceTypeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceTypes



        /// <summary>
        /// Describes the details of the instance types that are offered in a location. The results
        /// can be filtered by the attributes of the instance types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceTypes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceTypes">REST API Reference for DescribeInstanceTypes Operation</seealso>
        Task<DescribeInstanceTypesResponse> DescribeInstanceTypesAsync(DescribeInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInternetGateways


        /// <summary>
        /// Describes one or more of your internet gateways.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpamPools



        /// <summary>
        /// Get information about your IPAM pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpamPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpamPools service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIpamPools">REST API Reference for DescribeIpamPools Operation</seealso>
        Task<DescribeIpamPoolsResponse> DescribeIpamPoolsAsync(DescribeIpamPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpams



        /// <summary>
        /// Get information about your IPAM pools.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/what-is-it-ipam.html">What is
        /// IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpams service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIpams">REST API Reference for DescribeIpams Operation</seealso>
        Task<DescribeIpamsResponse> DescribeIpamsAsync(DescribeIpamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpamScopes



        /// <summary>
        /// Get information about your IPAM scopes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpamScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpamScopes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIpamScopes">REST API Reference for DescribeIpamScopes Operation</seealso>
        Task<DescribeIpamScopesResponse> DescribeIpamScopesAsync(DescribeIpamScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpv6Pools



        /// <summary>
        /// Describes your IPv6 address pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpv6Pools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpv6Pools service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIpv6Pools">REST API Reference for DescribeIpv6Pools Operation</seealso>
        Task<DescribeIpv6PoolsResponse> DescribeIpv6PoolsAsync(DescribeIpv6PoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeKeyPairs


        /// <summary>
        /// Describes the specified key pairs or all of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified key pairs or all of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLaunchTemplates



        /// <summary>
        /// Describes one or more launch templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplates service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesAsync(DescribeLaunchTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLaunchTemplateVersions



        /// <summary>
        /// Describes one or more versions of a specified launch template. You can describe all
        /// versions, individual versions, or a range of versions. You can also describe all the
        /// latest versions or all the default versions of all the launch templates in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsAsync(DescribeLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGatewayRouteTables



        /// <summary>
        /// Describes one or more local gateway route tables. By default, all local gateway route
        /// tables are described. Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGatewayRouteTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGatewayRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGatewayRouteTables">REST API Reference for DescribeLocalGatewayRouteTables Operation</seealso>
        Task<DescribeLocalGatewayRouteTablesResponse> DescribeLocalGatewayRouteTablesAsync(DescribeLocalGatewayRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations



        /// <summary>
        /// Describes the associations between virtual interface groups and local gateway route
        /// tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations">REST API Reference for DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations Operation</seealso>
        Task<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponse> DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsAsync(DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGatewayRouteTableVpcAssociations



        /// <summary>
        /// Describes the specified associations between VPCs and local gateway route tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGatewayRouteTableVpcAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGatewayRouteTableVpcAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGatewayRouteTableVpcAssociations">REST API Reference for DescribeLocalGatewayRouteTableVpcAssociations Operation</seealso>
        Task<DescribeLocalGatewayRouteTableVpcAssociationsResponse> DescribeLocalGatewayRouteTableVpcAssociationsAsync(DescribeLocalGatewayRouteTableVpcAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGateways



        /// <summary>
        /// Describes one or more local gateways. By default, all local gateways are described.
        /// Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGateways">REST API Reference for DescribeLocalGateways Operation</seealso>
        Task<DescribeLocalGatewaysResponse> DescribeLocalGatewaysAsync(DescribeLocalGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGatewayVirtualInterfaceGroups



        /// <summary>
        /// Describes the specified local gateway virtual interface groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGatewayVirtualInterfaceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGatewayVirtualInterfaceGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGatewayVirtualInterfaceGroups">REST API Reference for DescribeLocalGatewayVirtualInterfaceGroups Operation</seealso>
        Task<DescribeLocalGatewayVirtualInterfaceGroupsResponse> DescribeLocalGatewayVirtualInterfaceGroupsAsync(DescribeLocalGatewayVirtualInterfaceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocalGatewayVirtualInterfaces



        /// <summary>
        /// Describes the specified local gateway virtual interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocalGatewayVirtualInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocalGatewayVirtualInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLocalGatewayVirtualInterfaces">REST API Reference for DescribeLocalGatewayVirtualInterfaces Operation</seealso>
        Task<DescribeLocalGatewayVirtualInterfacesResponse> DescribeLocalGatewayVirtualInterfacesAsync(DescribeLocalGatewayVirtualInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeManagedPrefixLists



        /// <summary>
        /// Describes your managed prefix lists and any Amazon Web Services-managed prefix lists.
        /// 
        ///  
        /// <para>
        /// To view the entries for your prefix list, use <a>GetManagedPrefixListEntries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedPrefixLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeManagedPrefixLists service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeManagedPrefixLists">REST API Reference for DescribeManagedPrefixLists Operation</seealso>
        Task<DescribeManagedPrefixListsResponse> DescribeManagedPrefixListsAsync(DescribeManagedPrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMovingAddresses



        /// <summary>
        /// Describes your Elastic IP addresses that are being moved to the EC2-VPC platform,
        /// or that are being restored to the EC2-Classic platform. This request does not return
        /// information about any other Elastic IP addresses in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMovingAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNatGateways



        /// <summary>
        /// Describes one or more of your NAT gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNatGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkAcls


        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInsightsAccessScopeAnalyses



        /// <summary>
        /// Describes the specified Network Access Scope analyses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInsightsAccessScopeAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInsightsAccessScopeAnalyses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInsightsAccessScopeAnalyses">REST API Reference for DescribeNetworkInsightsAccessScopeAnalyses Operation</seealso>
        Task<DescribeNetworkInsightsAccessScopeAnalysesResponse> DescribeNetworkInsightsAccessScopeAnalysesAsync(DescribeNetworkInsightsAccessScopeAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInsightsAccessScopes



        /// <summary>
        /// Describes the specified Network Access Scopes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInsightsAccessScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInsightsAccessScopes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInsightsAccessScopes">REST API Reference for DescribeNetworkInsightsAccessScopes Operation</seealso>
        Task<DescribeNetworkInsightsAccessScopesResponse> DescribeNetworkInsightsAccessScopesAsync(DescribeNetworkInsightsAccessScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInsightsAnalyses



        /// <summary>
        /// Describes one or more of your network insights analyses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInsightsAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInsightsAnalyses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInsightsAnalyses">REST API Reference for DescribeNetworkInsightsAnalyses Operation</seealso>
        Task<DescribeNetworkInsightsAnalysesResponse> DescribeNetworkInsightsAnalysesAsync(DescribeNetworkInsightsAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInsightsPaths



        /// <summary>
        /// Describes one or more of your paths.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInsightsPaths service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInsightsPaths service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInsightsPaths">REST API Reference for DescribeNetworkInsightsPaths Operation</seealso>
        Task<DescribeNetworkInsightsPathsResponse> DescribeNetworkInsightsPathsAsync(DescribeNetworkInsightsPathsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInterfaceAttribute



        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInterfacePermissions



        /// <summary>
        /// Describes the permissions for your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfacePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsAsync(DescribeNetworkInterfacePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNetworkInterfaces


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePlacementGroups


        /// <summary>
        /// Describes the specified placement groups or all of your placement groups. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified placement groups or all of your placement groups. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePrefixLists



        /// <summary>
        /// Describes available Amazon Web Services services in a prefix list format, which includes
        /// the prefix list name and prefix list ID of the service and the IP address range for
        /// the service.
        /// 
        ///  
        /// <para>
        /// We recommend that you use <a>DescribeManagedPrefixLists</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrefixLists service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePrincipalIdFormat



        /// <summary>
        /// Describes the ID format settings for the root user and all IAM roles and IAM users
        /// that have explicitly specified a longer ID (17-character ID) preference. 
        /// 
        ///  
        /// <para>
        /// By default, all IAM roles and IAM users default to the same ID settings as the root
        /// user, unless they explicitly override the settings. This request is useful for identifying
        /// those IAM users and IAM roles that have overridden the default ID settings.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrincipalIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        Task<DescribePrincipalIdFormatResponse> DescribePrincipalIdFormatAsync(DescribePrincipalIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePublicIpv4Pools



        /// <summary>
        /// Describes the specified IPv4 address pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublicIpv4Pools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePublicIpv4Pools service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePublicIpv4Pools">REST API Reference for DescribePublicIpv4Pools Operation</seealso>
        Task<DescribePublicIpv4PoolsResponse> DescribePublicIpv4PoolsAsync(DescribePublicIpv4PoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRegions


        /// <summary>
        /// Describes the Regions that are enabled for your account, or all Regions.
        /// 
        ///  
        /// <para>
        /// For a list of the Regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/ec2-service.html">
        /// Amazon Elastic Compute Cloud endpoints and quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about enabling and disabling Regions for your account, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
        /// Amazon Web Services Regions</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        Task<DescribeRegionsResponse> DescribeRegionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the Regions that are enabled for your account, or all Regions.
        /// 
        ///  
        /// <para>
        /// For a list of the Regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/ec2-service.html">
        /// Amazon Elastic Compute Cloud endpoints and quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about enabling and disabling Regions for your account, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
        /// Amazon Web Services Regions</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplaceRootVolumeTasks



        /// <summary>
        /// Describes a root volume replacement task. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-restoring-volume.html#replace-root">Replace
        /// a root volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplaceRootVolumeTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplaceRootVolumeTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReplaceRootVolumeTasks">REST API Reference for DescribeReplaceRootVolumeTasks Operation</seealso>
        Task<DescribeReplaceRootVolumeTasksResponse> DescribeReplaceRootVolumeTasksAsync(DescribeReplaceRootVolumeTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstances


        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesListings


        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesModifications


        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstancesOfferings


        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRouteTables


        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScheduledInstanceAvailability



        /// <summary>
        /// Finds available schedules that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// You can search for an available schedule no more than 3 months in advance. You must
        /// meet the minimum required duration of 1,200 hours per year. For example, the minimum
        /// daily schedule is 4 hours, the minimum weekly schedule is 24 hours, and the minimum
        /// monthly schedule is 100 hours.
        /// </para>
        ///  
        /// <para>
        /// After you find a schedule that meets your needs, call <a>PurchaseScheduledInstances</a>
        /// to purchase Scheduled Instances with that schedule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledInstanceAvailability service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        Task<DescribeScheduledInstanceAvailabilityResponse> DescribeScheduledInstanceAvailabilityAsync(DescribeScheduledInstanceAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScheduledInstances



        /// <summary>
        /// Describes the specified Scheduled Instances or all your Scheduled Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        Task<DescribeScheduledInstancesResponse> DescribeScheduledInstancesAsync(DescribeScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityGroupReferences



        /// <summary>
        /// [VPC only] Describes the VPCs on the other side of a VPC peering connection that are
        /// referencing the security groups you've specified in this request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroupReferences service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityGroupRules



        /// <summary>
        /// Describes one or more of your security group rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroupRules service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupRules">REST API Reference for DescribeSecurityGroupRules Operation</seealso>
        Task<DescribeSecurityGroupRulesResponse> DescribeSecurityGroupRulesAsync(DescribeSecurityGroupRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityGroups


        /// <summary>
        /// Describes the specified security groups or all of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 security groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// groups for your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified security groups or all of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 security groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// groups for your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotAttribute



        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshots


        /// <summary>
        /// Describes the specified EBS snapshots available to you or all of the EBS snapshots
        /// available to you.
        /// 
        ///  
        /// <para>
        /// The snapshots available to you include public snapshots, private snapshots that you
        /// own, and private snapshots owned by other Amazon Web Services accounts for which you
        /// have explicit create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All Amazon Web Services accounts have create
        /// volume permissions for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An Amazon Web Services account has implicit create volume permissions
        /// for all snapshots it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be filtered by specifying snapshot IDs, snapshot
        /// owners, or Amazon Web Services accounts with create volume permissions. If no options
        /// are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the Amazon Web Services account IDs of the specified owners,
        /// <code>amazon</code> for snapshots owned by Amazon, or <code>self</code> for snapshots
        /// that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify Amazon Web Services account IDs (if
        /// you own the snapshots), <code>self</code> for snapshots for which you own or have
        /// explicit permissions, or <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, we recommend that you paginate the
        /// output to make the list more manageable. The <code>MaxResults</code> parameter sets
        /// the maximum number of results returned in a single page. If the list of results exceeds
        /// your <code>MaxResults</code> value, then that number of results is returned along
        /// with a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSnapshots</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// To get the state of fast snapshot restores for a snapshot, use <a>DescribeFastSnapshotRestores</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified EBS snapshots available to you or all of the EBS snapshots
        /// available to you.
        /// 
        ///  
        /// <para>
        /// The snapshots available to you include public snapshots, private snapshots that you
        /// own, and private snapshots owned by other Amazon Web Services accounts for which you
        /// have explicit create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All Amazon Web Services accounts have create
        /// volume permissions for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An Amazon Web Services account has implicit create volume permissions
        /// for all snapshots it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be filtered by specifying snapshot IDs, snapshot
        /// owners, or Amazon Web Services accounts with create volume permissions. If no options
        /// are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the Amazon Web Services account IDs of the specified owners,
        /// <code>amazon</code> for snapshots owned by Amazon, or <code>self</code> for snapshots
        /// that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify Amazon Web Services account IDs (if
        /// you own the snapshots), <code>self</code> for snapshots for which you own or have
        /// explicit permissions, or <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, we recommend that you paginate the
        /// output to make the list more manageable. The <code>MaxResults</code> parameter sets
        /// the maximum number of results returned in a single page. If the list of results exceeds
        /// your <code>MaxResults</code> value, then that number of results is returned along
        /// with a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSnapshots</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// To get the state of fast snapshot restores for a snapshot, use <a>DescribeFastSnapshotRestores</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshotTierStatus



        /// <summary>
        /// Describes the storage tier status of one or more Amazon EBS snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotTierStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotTierStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotTierStatus">REST API Reference for DescribeSnapshotTierStatus Operation</seealso>
        Task<DescribeSnapshotTierStatusResponse> DescribeSnapshotTierStatusAsync(DescribeSnapshotTierStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotDatafeedSubscription


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance data feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance data feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotFleetInstances



        /// <summary>
        /// Describes the running instances for the specified Spot Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotFleetRequestHistory



        /// <summary>
        /// Describes the events for the specified Spot Fleet request during the specified time.
        /// 
        ///  
        /// <para>
        /// Spot Fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// Spot Fleet events are available for 48 hours.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/fleet-monitor.html">Monitor
        /// fleet events using Amazon EventBridge</a> in the <i>Amazon EC2 User Guide for Linux
        /// Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequestHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotFleetRequests



        /// <summary>
        /// Describes your Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// Spot Fleet requests are deleted 48 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotInstanceRequests


        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances">DescribeInstances</a>
        /// with a filter to look for instances where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
        /// limit the number of results returned. This paginates the output, which makes the list
        /// more manageable and returns the results faster. If the list of results exceeds your
        /// <code>MaxResults</code> value, then that number of results is returned along with
        /// a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances">DescribeInstances</a>
        /// with a filter to look for instances where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
        /// limit the number of results returned. This paginates the output, which makes the list
        /// more manageable and returns the results faster. If the list of results exceeds your
        /// <code>MaxResults</code> value, then that number of results is returned along with
        /// a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpotPriceHistory


        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance pricing history</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, the operation returns the prices of the instance
        /// types within that time range. It also returns the last price change before the start
        /// time, which is the effective price as of the start time.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance pricing history</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, the operation returns the prices of the instance
        /// types within that time range. It also returns the last price change before the start
        /// time, which is the effective price as of the start time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStaleSecurityGroups



        /// <summary>
        /// [VPC only] Describes the stale security group rules for security groups in a specified
        /// VPC. Rules are stale when they reference a deleted security group in a peer VPC, or
        /// a security group in a peer VPC for which the VPC peering connection has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStaleSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        Task<DescribeStaleSecurityGroupsResponse> DescribeStaleSecurityGroupsAsync(DescribeStaleSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStoreImageTasks



        /// <summary>
        /// Describes the progress of the AMI store tasks. You can describe the store tasks for
        /// specified AMIs. If you don't specify the AMIs, you get a paginated list of store tasks
        /// from the last 31 days.
        /// 
        ///  
        /// <para>
        /// For each AMI task, the response indicates if the task is <code>InProgress</code>,
        /// <code>Completed</code>, or <code>Failed</code>. For tasks <code>InProgress</code>,
        /// the response shows the estimated progress as a percentage.
        /// </para>
        ///  
        /// <para>
        /// Tasks are listed in reverse chronological order. Currently, only tasks from the past
        /// 31 days can be viewed.
        /// </para>
        ///  
        /// <para>
        /// To use this API, you must have the required permissions. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
        /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
        /// and restore an AMI using Amazon S3</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStoreImageTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStoreImageTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStoreImageTasks">REST API Reference for DescribeStoreImageTasks Operation</seealso>
        Task<DescribeStoreImageTasksResponse> DescribeStoreImageTasksAsync(DescribeStoreImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubnets


        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">Your
        /// VPC and subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        Task<DescribeSubnetsResponse> DescribeSubnetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">Your
        /// VPC and subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Describes the specified tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrafficMirrorFilters



        /// <summary>
        /// Describes one or more Traffic Mirror filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficMirrorFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrafficMirrorFilters service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTrafficMirrorFilters">REST API Reference for DescribeTrafficMirrorFilters Operation</seealso>
        Task<DescribeTrafficMirrorFiltersResponse> DescribeTrafficMirrorFiltersAsync(DescribeTrafficMirrorFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrafficMirrorSessions



        /// <summary>
        /// Describes one or more Traffic Mirror sessions. By default, all Traffic Mirror sessions
        /// are described. Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficMirrorSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrafficMirrorSessions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTrafficMirrorSessions">REST API Reference for DescribeTrafficMirrorSessions Operation</seealso>
        Task<DescribeTrafficMirrorSessionsResponse> DescribeTrafficMirrorSessionsAsync(DescribeTrafficMirrorSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrafficMirrorTargets



        /// <summary>
        /// Information about one or more Traffic Mirror targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficMirrorTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrafficMirrorTargets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTrafficMirrorTargets">REST API Reference for DescribeTrafficMirrorTargets Operation</seealso>
        Task<DescribeTrafficMirrorTargetsResponse> DescribeTrafficMirrorTargetsAsync(DescribeTrafficMirrorTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayAttachments



        /// <summary>
        /// Describes one or more attachments between resources and transit gateways. By default,
        /// all attachments are described. Alternatively, you can filter the results by attachment
        /// ID, attachment state, resource ID, or resource owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayAttachments service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayAttachments">REST API Reference for DescribeTransitGatewayAttachments Operation</seealso>
        Task<DescribeTransitGatewayAttachmentsResponse> DescribeTransitGatewayAttachmentsAsync(DescribeTransitGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayConnectPeers



        /// <summary>
        /// Describes one or more Connect peers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayConnectPeers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayConnectPeers service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayConnectPeers">REST API Reference for DescribeTransitGatewayConnectPeers Operation</seealso>
        Task<DescribeTransitGatewayConnectPeersResponse> DescribeTransitGatewayConnectPeersAsync(DescribeTransitGatewayConnectPeersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayConnects



        /// <summary>
        /// Describes one or more Connect attachments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayConnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayConnects service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayConnects">REST API Reference for DescribeTransitGatewayConnects Operation</seealso>
        Task<DescribeTransitGatewayConnectsResponse> DescribeTransitGatewayConnectsAsync(DescribeTransitGatewayConnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayMulticastDomains



        /// <summary>
        /// Describes one or more transit gateway multicast domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayMulticastDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayMulticastDomains service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayMulticastDomains">REST API Reference for DescribeTransitGatewayMulticastDomains Operation</seealso>
        Task<DescribeTransitGatewayMulticastDomainsResponse> DescribeTransitGatewayMulticastDomainsAsync(DescribeTransitGatewayMulticastDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayPeeringAttachments



        /// <summary>
        /// Describes your transit gateway peering attachments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayPeeringAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayPeeringAttachments service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayPeeringAttachments">REST API Reference for DescribeTransitGatewayPeeringAttachments Operation</seealso>
        Task<DescribeTransitGatewayPeeringAttachmentsResponse> DescribeTransitGatewayPeeringAttachmentsAsync(DescribeTransitGatewayPeeringAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayRouteTables



        /// <summary>
        /// Describes one or more transit gateway route tables. By default, all transit gateway
        /// route tables are described. Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayRouteTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayRouteTables">REST API Reference for DescribeTransitGatewayRouteTables Operation</seealso>
        Task<DescribeTransitGatewayRouteTablesResponse> DescribeTransitGatewayRouteTablesAsync(DescribeTransitGatewayRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGateways



        /// <summary>
        /// Describes one or more transit gateways. By default, all transit gateways are described.
        /// Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGateways">REST API Reference for DescribeTransitGateways Operation</seealso>
        Task<DescribeTransitGatewaysResponse> DescribeTransitGatewaysAsync(DescribeTransitGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransitGatewayVpcAttachments



        /// <summary>
        /// Describes one or more VPC attachments. By default, all VPC attachments are described.
        /// Alternatively, you can filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayVpcAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransitGatewayVpcAttachments service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayVpcAttachments">REST API Reference for DescribeTransitGatewayVpcAttachments Operation</seealso>
        Task<DescribeTransitGatewayVpcAttachmentsResponse> DescribeTransitGatewayVpcAttachmentsAsync(DescribeTransitGatewayVpcAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrunkInterfaceAssociations



        /// <summary>
        /// <note> 
        /// <para>
        /// This API action is currently in <b>limited preview only</b>. If you are interested
        /// in using this feature, contact your account manager.
        /// </para>
        ///  </note> 
        /// <para>
        /// Describes one or more network interface trunk associations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrunkInterfaceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrunkInterfaceAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTrunkInterfaceAssociations">REST API Reference for DescribeTrunkInterfaceAssociations Operation</seealso>
        Task<DescribeTrunkInterfaceAssociationsResponse> DescribeTrunkInterfaceAssociationsAsync(DescribeTrunkInterfaceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumeAttribute



        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumes


        /// <summary>
        /// Describes the specified EBS volumes or all of your EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, we recommend that you paginate the output
        /// to make the list more manageable. The <code>MaxResults</code> parameter sets the maximum
        /// number of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        Task<DescribeVolumesResponse> DescribeVolumesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified EBS volumes or all of your EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, we recommend that you paginate the output
        /// to make the list more manageable. The <code>MaxResults</code> parameter sets the maximum
        /// number of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumesModifications



        /// <summary>
        /// Describes the most recent volume modification request for the specified EBS volumes.
        /// 
        ///  
        /// <para>
        /// If a volume has never been modified, some information in the output will be null.
        /// If a volume has been modified more than once, the output includes only the most recent
        /// modification request.
        /// </para>
        ///  
        /// <para>
        /// You can also use CloudWatch Events to check the status of a modification to an EBS
        /// volume. For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-modifications.html">Monitor
        /// the progress of volume modifications</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        Task<DescribeVolumesModificationsResponse> DescribeVolumesModificationsAsync(DescribeVolumesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumeStatus


        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks might still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitor
        /// the status of your volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and might require you to take
        /// action. For example, if your volume returns an <code>impaired</code> status, then
        /// the volume event might be <code>potential-data-inconsistency</code>. This means that
        /// your volume has been affected by an issue with the underlying host, has all I/O operations
        /// disabled, and might have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you might have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks might still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitor
        /// the status of your volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and might require you to take
        /// action. For example, if your volume returns an <code>impaired</code> status, then
        /// the volume event might be <code>potential-data-inconsistency</code>. This means that
        /// your volume has been affected by an issue with the underlying host, has all I/O operations
        /// disabled, and might have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you might have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcAttribute



        /// <summary>
        /// Describes the specified attribute of the specified VPC. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcClassicLink



        /// <summary>
        /// Describes the ClassicLink status of one or more VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcClassicLinkDnsSupport



        /// <summary>
        /// Describes the ClassicLink DNS support status of one or more VPCs. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        Task<DescribeVpcClassicLinkDnsSupportResponse> DescribeVpcClassicLinkDnsSupportAsync(DescribeVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpointConnectionNotifications



        /// <summary>
        /// Describes the connection notifications for VPC endpoints and VPC endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        Task<DescribeVpcEndpointConnectionNotificationsResponse> DescribeVpcEndpointConnectionNotificationsAsync(DescribeVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpointConnections



        /// <summary>
        /// Describes the VPC endpoint connections to your VPC endpoint services, including any
        /// endpoints that are pending your acceptance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        Task<DescribeVpcEndpointConnectionsResponse> DescribeVpcEndpointConnectionsAsync(DescribeVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpoints



        /// <summary>
        /// Describes one or more of your VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpointServiceConfigurations



        /// <summary>
        /// Describes the VPC endpoint service configurations in your account (your services).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        Task<DescribeVpcEndpointServiceConfigurationsResponse> DescribeVpcEndpointServiceConfigurationsAsync(DescribeVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpointServicePermissions



        /// <summary>
        /// Describes the principals (service consumers) that are permitted to discover your VPC
        /// endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        Task<DescribeVpcEndpointServicePermissionsResponse> DescribeVpcEndpointServicePermissionsAsync(DescribeVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpointServices



        /// <summary>
        /// Describes available services to which you can create a VPC endpoint.
        /// 
        ///  
        /// <para>
        /// When the service provider and the consumer have different accounts in multiple Availability
        /// Zones, and the consumer views the VPC endpoint service information, the response only
        /// includes the common Availability Zones. For example, when the service provider account
        /// uses <code>us-east-1a</code> and <code>us-east-1c</code> and the consumer uses <code>us-east-1a</code>
        /// and <code>us-east-1b</code>, the response includes the VPC endpoint services in the
        /// common Availability Zone, <code>us-east-1a</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServices service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcs


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        Task<DescribeVpcsResponse> DescribeVpcsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpnConnections


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpnGateways


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
        /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachClassicLinkVpc



        /// <summary>
        /// Unlinks (detaches) a linked EC2-Classic instance from a VPC. After the instance has
        /// been unlinked, the VPC security groups are no longer associated with it. An instance
        /// is automatically unlinked from a VPC when it's stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachInternetGateway



        /// <summary>
        /// Detaches an internet gateway from a VPC, disabling connectivity between the internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses
        /// or public IPv4 addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachNetworkInterface



        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachVolume



        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so can result in the volume becoming stuck in the <code>busy</code> state while detaching.
        /// If this happens, detachment can be delayed indefinitely until you unmount the volume,
        /// force detachment, reboot the instance, or all three. If an EBS volume is the root
        /// device of an instance, it can't be detached while the instance is running. To detach
        /// the root volume, stop the instance first.
        /// 
        ///  
        /// <para>
        /// When a volume with an Amazon Web Services Marketplace product code is detached from
        /// an instance, the product code is no longer associated with the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detach
        /// an Amazon EBS volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachVpnGateway



        /// <summary>
        /// Detaches a virtual private gateway from a VPC. You do this if you're planning to turn
        /// off the VPC and not use it anymore. You can confirm a virtual private gateway has
        /// been completely detached from a VPC by describing the virtual private gateway (any
        /// attachments to the virtual private gateway are also described).
        /// 
        ///  
        /// <para>
        /// You must wait for the attachment's state to switch to <code>detached</code> before
        /// you can delete the VPC or attach a different VPC to the virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableEbsEncryptionByDefault



        /// <summary>
        /// Disables EBS encryption by default for your account in the current Region.
        /// 
        ///  
        /// <para>
        /// After you disable encryption by default, you can still create encrypted volumes by
        /// enabling encryption when you create each volume.
        /// </para>
        ///  
        /// <para>
        /// Disabling encryption by default does not change the encryption status of your existing
        /// volumes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableEbsEncryptionByDefault">REST API Reference for DisableEbsEncryptionByDefault Operation</seealso>
        Task<DisableEbsEncryptionByDefaultResponse> DisableEbsEncryptionByDefaultAsync(DisableEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableFastSnapshotRestores



        /// <summary>
        /// Disables fast snapshot restores for the specified snapshots in the specified Availability
        /// Zones.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableFastSnapshotRestores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableFastSnapshotRestores service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableFastSnapshotRestores">REST API Reference for DisableFastSnapshotRestores Operation</seealso>
        Task<DisableFastSnapshotRestoresResponse> DisableFastSnapshotRestoresAsync(DisableFastSnapshotRestoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableImageDeprecation



        /// <summary>
        /// Cancels the deprecation of the specified AMI.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-deprecate.html">Deprecate
        /// an AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableImageDeprecation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableImageDeprecation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableImageDeprecation">REST API Reference for DisableImageDeprecation Operation</seealso>
        Task<DisableImageDeprecationResponse> DisableImageDeprecationAsync(DisableImageDeprecationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableIpamOrganizationAdminAccount



        /// <summary>
        /// Disable the IPAM account. For more information, see <a href="/vpc/latest/ipam/enable-integ-ipam.html">Enable
        /// integration with Organizations</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableIpamOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableIpamOrganizationAdminAccount service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableIpamOrganizationAdminAccount">REST API Reference for DisableIpamOrganizationAdminAccount Operation</seealso>
        Task<DisableIpamOrganizationAdminAccountResponse> DisableIpamOrganizationAdminAccountAsync(DisableIpamOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableSerialConsoleAccess



        /// <summary>
        /// Disables access to the EC2 serial console of all instances for your account. By default,
        /// access to the EC2 serial console is disabled for your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configure-access-to-serial-console.html#serial-console-account-access">Manage
        /// account access to the EC2 serial console</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSerialConsoleAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSerialConsoleAccess service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableSerialConsoleAccess">REST API Reference for DisableSerialConsoleAccess Operation</seealso>
        Task<DisableSerialConsoleAccessResponse> DisableSerialConsoleAccessAsync(DisableSerialConsoleAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableTransitGatewayRouteTablePropagation



        /// <summary>
        /// Disables the specified resource attachment from propagating routes to the specified
        /// propagation route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTransitGatewayRouteTablePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableTransitGatewayRouteTablePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableTransitGatewayRouteTablePropagation">REST API Reference for DisableTransitGatewayRouteTablePropagation Operation</seealso>
        Task<DisableTransitGatewayRouteTablePropagationResponse> DisableTransitGatewayRouteTablePropagationAsync(DisableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableVgwRoutePropagation



        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to a specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableVpcClassicLink



        /// <summary>
        /// Disables ClassicLink for a VPC. You cannot disable ClassicLink for a VPC that has
        /// EC2-Classic instances linked to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableVpcClassicLinkDnsSupport



        /// <summary>
        /// Disables ClassicLink DNS support for a VPC. If disabled, DNS hostnames resolve to
        /// public IP addresses when addressed between a linked EC2-Classic instance and instances
        /// in the VPC to which it's linked. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify a VPC ID in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        Task<DisableVpcClassicLinkDnsSupportResponse> DisableVpcClassicLinkDnsSupportAsync(DisableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAddress



        /// <summary>
        /// Disassociates an Elastic IP address from the instance or network interface it's associated
        /// with.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateClientVpnTargetNetwork



        /// <summary>
        /// Disassociates a target network from the specified Client VPN endpoint. When you disassociate
        /// the last target network from a Client VPN, the following happens:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The route that was automatically added for the VPC is deleted
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All active client connections are terminated
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New client connections are disallowed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Client VPN endpoint's status changes to <code>pending-associate</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateClientVpnTargetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateClientVpnTargetNetwork service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateClientVpnTargetNetwork">REST API Reference for DisassociateClientVpnTargetNetwork Operation</seealso>
        Task<DisassociateClientVpnTargetNetworkResponse> DisassociateClientVpnTargetNetworkAsync(DisassociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateEnclaveCertificateIamRole



        /// <summary>
        /// Disassociates an IAM role from an Certificate Manager (ACM) certificate. Disassociating
        /// an IAM role from an ACM certificate removes the Amazon S3 object that contains the
        /// certificate, certificate chain, and encrypted private key from the Amazon S3 bucket.
        /// It also revokes the IAM role's permission to use the KMS key used to encrypt the private
        /// key. This effectively revokes the role's permission to use the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnclaveCertificateIamRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEnclaveCertificateIamRole service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateEnclaveCertificateIamRole">REST API Reference for DisassociateEnclaveCertificateIamRole Operation</seealso>
        Task<DisassociateEnclaveCertificateIamRoleResponse> DisassociateEnclaveCertificateIamRoleAsync(DisassociateEnclaveCertificateIamRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateIamInstanceProfile



        /// <summary>
        /// Disassociates an IAM instance profile from a running or stopped instance.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        Task<DisassociateIamInstanceProfileResponse> DisassociateIamInstanceProfileAsync(DisassociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateInstanceEventWindow



        /// <summary>
        /// Disassociates one or more targets from an event window.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateInstanceEventWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateInstanceEventWindow service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateInstanceEventWindow">REST API Reference for DisassociateInstanceEventWindow Operation</seealso>
        Task<DisassociateInstanceEventWindowResponse> DisassociateInstanceEventWindowAsync(DisassociateInstanceEventWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateRouteTable



        /// <summary>
        /// Disassociates a subnet or gateway from a route table.
        /// 
        ///  
        /// <para>
        /// After you perform this action, the subnet no longer uses the routes in the route table.
        /// Instead, it uses the routes in the VPC's main route table. For more information about
        /// route tables, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateSubnetCidrBlock



        /// <summary>
        /// Disassociates a CIDR block from a subnet. Currently, you can disassociate an IPv6
        /// CIDR block only. You must detach or delete all gateways and resources that are associated
        /// with the CIDR block before you can disassociate it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        Task<DisassociateSubnetCidrBlockResponse> DisassociateSubnetCidrBlockAsync(DisassociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTransitGatewayMulticastDomain



        /// <summary>
        /// Disassociates the specified subnets from the transit gateway multicast domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayMulticastDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTransitGatewayMulticastDomain service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateTransitGatewayMulticastDomain">REST API Reference for DisassociateTransitGatewayMulticastDomain Operation</seealso>
        Task<DisassociateTransitGatewayMulticastDomainResponse> DisassociateTransitGatewayMulticastDomainAsync(DisassociateTransitGatewayMulticastDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTransitGatewayRouteTable



        /// <summary>
        /// Disassociates a resource attachment from a transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayRouteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTransitGatewayRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateTransitGatewayRouteTable">REST API Reference for DisassociateTransitGatewayRouteTable Operation</seealso>
        Task<DisassociateTransitGatewayRouteTableResponse> DisassociateTransitGatewayRouteTableAsync(DisassociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTrunkInterface



        /// <summary>
        /// <note> 
        /// <para>
        /// This API action is currently in <b>limited preview only</b>. If you are interested
        /// in using this feature, contact your account manager.
        /// </para>
        ///  </note> 
        /// <para>
        /// Removes an association between a branch network interface with a trunk network interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrunkInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrunkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateTrunkInterface">REST API Reference for DisassociateTrunkInterface Operation</seealso>
        Task<DisassociateTrunkInterfaceResponse> DisassociateTrunkInterfaceAsync(DisassociateTrunkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateVpcCidrBlock



        /// <summary>
        /// Disassociates a CIDR block from a VPC. To disassociate the CIDR block, you must specify
        /// its association ID. You can get the association ID by using <a>DescribeVpcs</a>. You
        /// must detach or delete all gateways and resources that are associated with the CIDR
        /// block before you can disassociate it. 
        /// 
        ///  
        /// <para>
        /// You cannot disassociate the CIDR block with which you originally created the VPC (the
        /// primary CIDR block).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        Task<DisassociateVpcCidrBlockResponse> DisassociateVpcCidrBlockAsync(DisassociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableEbsEncryptionByDefault



        /// <summary>
        /// Enables EBS encryption by default for your account in the current Region.
        /// 
        ///  
        /// <para>
        /// After you enable encryption by default, the EBS volumes that you create are always
        /// encrypted, either using the default KMS key or the KMS key that you specified when
        /// you created each volume. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the default KMS key for encryption by default using <a>ModifyEbsDefaultKmsKeyId</a>
        /// or <a>ResetEbsDefaultKmsKeyId</a>.
        /// </para>
        ///  
        /// <para>
        /// Enabling encryption by default has no effect on the encryption status of your existing
        /// volumes.
        /// </para>
        ///  
        /// <para>
        /// After you enable encryption by default, you can no longer launch instances using instance
        /// types that do not support encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// instance types</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableEbsEncryptionByDefault">REST API Reference for EnableEbsEncryptionByDefault Operation</seealso>
        Task<EnableEbsEncryptionByDefaultResponse> EnableEbsEncryptionByDefaultAsync(EnableEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableFastSnapshotRestores



        /// <summary>
        /// Enables fast snapshot restores for the specified snapshots in the specified Availability
        /// Zones.
        /// 
        ///  
        /// <para>
        /// You get the full benefit of fast snapshot restores after they enter the <code>enabled</code>
        /// state. To get the current state of fast snapshot restores, use <a>DescribeFastSnapshotRestores</a>.
        /// To disable fast snapshot restores, use <a>DisableFastSnapshotRestores</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-fast-snapshot-restore.html">Amazon
        /// EBS fast snapshot restore</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableFastSnapshotRestores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableFastSnapshotRestores service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableFastSnapshotRestores">REST API Reference for EnableFastSnapshotRestores Operation</seealso>
        Task<EnableFastSnapshotRestoresResponse> EnableFastSnapshotRestoresAsync(EnableFastSnapshotRestoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableImageDeprecation



        /// <summary>
        /// Enables deprecation of the specified AMI at the specified date and time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-deprecate.html">Deprecate
        /// an AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableImageDeprecation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableImageDeprecation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableImageDeprecation">REST API Reference for EnableImageDeprecation Operation</seealso>
        Task<EnableImageDeprecationResponse> EnableImageDeprecationAsync(EnableImageDeprecationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableIpamOrganizationAdminAccount



        /// <summary>
        /// Enable an Organizations member account as the IPAM admin account. You cannot select
        /// the Organizations management account as the IPAM admin account. For more information,
        /// see <a href="/vpc/latest/ipam/enable-integ-ipam.html">Enable integration with Organizations</a>
        /// in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableIpamOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableIpamOrganizationAdminAccount service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableIpamOrganizationAdminAccount">REST API Reference for EnableIpamOrganizationAdminAccount Operation</seealso>
        Task<EnableIpamOrganizationAdminAccountResponse> EnableIpamOrganizationAdminAccountAsync(EnableIpamOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableSerialConsoleAccess



        /// <summary>
        /// Enables access to the EC2 serial console of all instances for your account. By default,
        /// access to the EC2 serial console is disabled for your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configure-access-to-serial-console.html#serial-console-account-access">Manage
        /// account access to the EC2 serial console</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSerialConsoleAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSerialConsoleAccess service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableSerialConsoleAccess">REST API Reference for EnableSerialConsoleAccess Operation</seealso>
        Task<EnableSerialConsoleAccessResponse> EnableSerialConsoleAccessAsync(EnableSerialConsoleAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableTransitGatewayRouteTablePropagation



        /// <summary>
        /// Enables the specified attachment to propagate routes to the specified propagation
        /// route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTransitGatewayRouteTablePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableTransitGatewayRouteTablePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableTransitGatewayRouteTablePropagation">REST API Reference for EnableTransitGatewayRouteTablePropagation Operation</seealso>
        Task<EnableTransitGatewayRouteTablePropagationResponse> EnableTransitGatewayRouteTablePropagationAsync(EnableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVgwRoutePropagation



        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVolumeIO



        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled because the data
        /// on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVolumeIO service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVpcClassicLink



        /// <summary>
        /// Enables a VPC for ClassicLink. You can then link EC2-Classic instances to your ClassicLink-enabled
        /// VPC to allow communication over private IP addresses. You cannot enable your VPC for
        /// ClassicLink if any of your VPC route tables have existing routes for address ranges
        /// within the <code>10.0.0.0/8</code> IP address range, excluding local routes for VPCs
        /// in the <code>10.0.0.0/16</code> and <code>10.1.0.0/16</code> IP address ranges. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableVpcClassicLinkDnsSupport



        /// <summary>
        /// Enables a VPC to support DNS hostname resolution for ClassicLink. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify a VPC ID in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        Task<EnableVpcClassicLinkDnsSupportResponse> EnableVpcClassicLinkDnsSupportAsync(EnableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportClientVpnClientCertificateRevocationList



        /// <summary>
        /// Downloads the client certificate revocation list for the specified Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientCertificateRevocationList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportClientVpnClientCertificateRevocationList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientCertificateRevocationList">REST API Reference for ExportClientVpnClientCertificateRevocationList Operation</seealso>
        Task<ExportClientVpnClientCertificateRevocationListResponse> ExportClientVpnClientCertificateRevocationListAsync(ExportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportClientVpnClientConfiguration



        /// <summary>
        /// Downloads the contents of the Client VPN endpoint configuration file for the specified
        /// Client VPN endpoint. The Client VPN endpoint configuration file includes the Client
        /// VPN endpoint and certificate information clients need to establish a connection with
        /// the Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportClientVpnClientConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientConfiguration">REST API Reference for ExportClientVpnClientConfiguration Operation</seealso>
        Task<ExportClientVpnClientConfigurationResponse> ExportClientVpnClientConfigurationAsync(ExportClientVpnClientConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportImage



        /// <summary>
        /// Exports an Amazon Machine Image (AMI) to a VM file. For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport_image.html">Exporting
        /// a VM directly from an Amazon Machine Image (AMI)</a> in the <i>VM Import/Export User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportImage">REST API Reference for ExportImage Operation</seealso>
        Task<ExportImageResponse> ExportImageAsync(ExportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportTransitGatewayRoutes



        /// <summary>
        /// Exports routes from the specified transit gateway route table to the specified S3
        /// bucket. By default, all routes are exported. Alternatively, you can filter by CIDR
        /// range.
        /// 
        ///  
        /// <para>
        /// The routes are saved to the specified bucket in a JSON file. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-route-tables.html#tgw-export-route-tables">Export
        /// Route Tables to Amazon S3</a> in <i>Transit Gateways</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportTransitGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportTransitGatewayRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportTransitGatewayRoutes">REST API Reference for ExportTransitGatewayRoutes Operation</seealso>
        Task<ExportTransitGatewayRoutesResponse> ExportTransitGatewayRoutesAsync(ExportTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssociatedEnclaveCertificateIamRoles



        /// <summary>
        /// Returns the IAM roles that are associated with the specified ACM (ACM) certificate.
        /// It also returns the name of the Amazon S3 bucket and the Amazon S3 object key where
        /// the certificate, certificate chain, and encrypted private key bundle are stored, and
        /// the ARN of the KMS key that's used to encrypt the private key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedEnclaveCertificateIamRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociatedEnclaveCertificateIamRoles service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetAssociatedEnclaveCertificateIamRoles">REST API Reference for GetAssociatedEnclaveCertificateIamRoles Operation</seealso>
        Task<GetAssociatedEnclaveCertificateIamRolesResponse> GetAssociatedEnclaveCertificateIamRolesAsync(GetAssociatedEnclaveCertificateIamRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssociatedIpv6PoolCidrs



        /// <summary>
        /// Gets information about the IPv6 CIDR block associations for a specified IPv6 address
        /// pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedIpv6PoolCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociatedIpv6PoolCidrs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetAssociatedIpv6PoolCidrs">REST API Reference for GetAssociatedIpv6PoolCidrs Operation</seealso>
        Task<GetAssociatedIpv6PoolCidrsResponse> GetAssociatedIpv6PoolCidrsAsync(GetAssociatedIpv6PoolCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCapacityReservationUsage



        /// <summary>
        /// Gets usage information about a Capacity Reservation. If the Capacity Reservation is
        /// shared, it shows usage information for the Capacity Reservation owner and each Amazon
        /// Web Services account that is currently using the shared capacity. If the Capacity
        /// Reservation is not shared, it shows only the Capacity Reservation owner's usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCapacityReservationUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCapacityReservationUsage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetCapacityReservationUsage">REST API Reference for GetCapacityReservationUsage Operation</seealso>
        Task<GetCapacityReservationUsageResponse> GetCapacityReservationUsageAsync(GetCapacityReservationUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCoipPoolUsage



        /// <summary>
        /// Describes the allocations from the specified customer-owned address pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoipPoolUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoipPoolUsage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetCoipPoolUsage">REST API Reference for GetCoipPoolUsage Operation</seealso>
        Task<GetCoipPoolUsageResponse> GetCoipPoolUsageAsync(GetCoipPoolUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConsoleOutput



        /// <summary>
        /// Gets the console output for the specified instance. For Linux instances, the instance
        /// console output displays the exact console output that would normally be displayed
        /// on a physical monitor attached to a computer. For Windows instances, the instance
        /// console output includes the last three system event log errors.
        /// 
        ///  
        /// <para>
        /// By default, the console output returns buffered information that was posted shortly
        /// after an instance transition state (start, stop, reboot, or terminate). This information
        /// is available for at least one hour after the most recent post. Only the most recent
        /// 64 KB of console output is available.
        /// </para>
        ///  
        /// <para>
        /// You can optionally retrieve the latest serial console output at any time during the
        /// instance lifecycle. This option is supported on instance types that use the Nitro
        /// hypervisor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html#instance-console-console-output">Instance
        /// console output</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConsoleScreenshot



        /// <summary>
        /// Retrieve a JPG-format screenshot of a running instance to help with troubleshooting.
        /// 
        ///  
        /// <para>
        /// The returned content is Base64-encoded.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConsoleScreenshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        Task<GetConsoleScreenshotResponse> GetConsoleScreenshotAsync(GetConsoleScreenshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDefaultCreditSpecification



        /// <summary>
        /// Describes the default credit option for CPU usage of a burstable performance instance
        /// family.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultCreditSpecification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultCreditSpecification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetDefaultCreditSpecification">REST API Reference for GetDefaultCreditSpecification Operation</seealso>
        Task<GetDefaultCreditSpecificationResponse> GetDefaultCreditSpecificationAsync(GetDefaultCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEbsDefaultKmsKeyId



        /// <summary>
        /// Describes the default KMS key for EBS encryption by default for your account in this
        /// Region. You can change the default KMS key for encryption by default using <a>ModifyEbsDefaultKmsKeyId</a>
        /// or <a>ResetEbsDefaultKmsKeyId</a>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetEbsDefaultKmsKeyId">REST API Reference for GetEbsDefaultKmsKeyId Operation</seealso>
        Task<GetEbsDefaultKmsKeyIdResponse> GetEbsDefaultKmsKeyIdAsync(GetEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEbsEncryptionByDefault



        /// <summary>
        /// Describes whether EBS encryption by default is enabled for your account in the current
        /// Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEbsEncryptionByDefault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEbsEncryptionByDefault service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetEbsEncryptionByDefault">REST API Reference for GetEbsEncryptionByDefault Operation</seealso>
        Task<GetEbsEncryptionByDefaultResponse> GetEbsEncryptionByDefaultAsync(GetEbsEncryptionByDefaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFlowLogsIntegrationTemplate



        /// <summary>
        /// Generates a CloudFormation template that streamlines and automates the integration
        /// of VPC flow logs with Amazon Athena. This make it easier for you to query and gain
        /// insights from VPC flow logs data. Based on the information that you provide, we configure
        /// resources in the template to do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Create a table in Athena that maps fields to a custom log format
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a Lambda function that updates the table with new partitions on a daily, weekly,
        /// or monthly basis
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a table partitioned between two timestamps in the past
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a set of named queries in Athena that you can use to get started quickly
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowLogsIntegrationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowLogsIntegrationTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetFlowLogsIntegrationTemplate">REST API Reference for GetFlowLogsIntegrationTemplate Operation</seealso>
        Task<GetFlowLogsIntegrationTemplateResponse> GetFlowLogsIntegrationTemplateAsync(GetFlowLogsIntegrationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroupsForCapacityReservation



        /// <summary>
        /// Lists the resource groups to which a Capacity Reservation has been added.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupsForCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupsForCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetGroupsForCapacityReservation">REST API Reference for GetGroupsForCapacityReservation Operation</seealso>
        Task<GetGroupsForCapacityReservationResponse> GetGroupsForCapacityReservationAsync(GetGroupsForCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostReservationPurchasePreview



        /// <summary>
        /// Preview a reservation purchase with configurations that match those of your Dedicated
        /// Host. You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// 
        ///  
        /// <para>
        /// This is a preview of the <a>PurchaseHostReservation</a> action and does not result
        /// in the offering being purchased.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostReservationPurchasePreview service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        Task<GetHostReservationPurchasePreviewResponse> GetHostReservationPurchasePreviewAsync(GetHostReservationPurchasePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInstanceTypesFromInstanceRequirements



        /// <summary>
        /// Returns a list of instance types with the specified instance attributes. You can use
        /// the response to preview the instance types without launching instances. Note that
        /// the response does not consider capacity.
        /// 
        ///  
        /// <para>
        /// When you specify multiple parameters, you get instance types that satisfy all of the
        /// specified parameters. If you specify multiple values for a parameter, you get instance
        /// types that satisfy any of the specified values.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-attribute-based-instance-type-selection.html#spotfleet-get-instance-types-from-instance-requirements">Preview
        /// instance types with specified attributes</a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html">Attribute-based
        /// instance type selection for EC2 Fleet</a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-attribute-based-instance-type-selection.html">Attribute-based
        /// instance type selection for Spot Fleet</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
        /// placement score</a> in the <i>Amazon EC2 User Guide</i>, and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-asg-instance-type-requirements.html">Creating
        /// an Auto Scaling group using attribute-based instance type selection</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceTypesFromInstanceRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceTypesFromInstanceRequirements service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetInstanceTypesFromInstanceRequirements">REST API Reference for GetInstanceTypesFromInstanceRequirements Operation</seealso>
        Task<GetInstanceTypesFromInstanceRequirementsResponse> GetInstanceTypesFromInstanceRequirementsAsync(GetInstanceTypesFromInstanceRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIpamAddressHistory



        /// <summary>
        /// Retrieve historical information about a CIDR within an IPAM scope. For more information,
        /// see <a href="/vpc/latest/ipam/view-history-cidr-ipam.html">View the history of IP
        /// addresses</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpamAddressHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIpamAddressHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetIpamAddressHistory">REST API Reference for GetIpamAddressHistory Operation</seealso>
        Task<GetIpamAddressHistoryResponse> GetIpamAddressHistoryAsync(GetIpamAddressHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIpamPoolAllocations



        /// <summary>
        /// Get a list of all the CIDR allocations in an IPAM pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpamPoolAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIpamPoolAllocations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetIpamPoolAllocations">REST API Reference for GetIpamPoolAllocations Operation</seealso>
        Task<GetIpamPoolAllocationsResponse> GetIpamPoolAllocationsAsync(GetIpamPoolAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIpamPoolCidrs



        /// <summary>
        /// Get the CIDRs provisioned to an IPAM pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpamPoolCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIpamPoolCidrs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetIpamPoolCidrs">REST API Reference for GetIpamPoolCidrs Operation</seealso>
        Task<GetIpamPoolCidrsResponse> GetIpamPoolCidrsAsync(GetIpamPoolCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIpamResourceCidrs



        /// <summary>
        /// Get information about the resources in a scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIpamResourceCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIpamResourceCidrs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetIpamResourceCidrs">REST API Reference for GetIpamResourceCidrs Operation</seealso>
        Task<GetIpamResourceCidrsResponse> GetIpamResourceCidrsAsync(GetIpamResourceCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLaunchTemplateData



        /// <summary>
        /// Retrieves the configuration data of the specified instance. You can use this data
        /// to create a launch template. 
        /// 
        ///  
        /// <para>
        /// This action calls on other describe actions to get instance information. Depending
        /// on your instance configuration, you may need to allow the following actions in your
        /// IAM policy: DescribeSpotInstanceRequests, DescribeInstanceCreditSpecifications, DescribeVolumes,
        /// DescribeInstanceAttribute, and DescribeElasticGpus. Or, you can allow <code>describe*</code>
        /// depending on your instance requirements.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchTemplateData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        Task<GetLaunchTemplateDataResponse> GetLaunchTemplateDataAsync(GetLaunchTemplateDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedPrefixListAssociations



        /// <summary>
        /// Gets information about the resources that are associated with the specified managed
        /// prefix list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedPrefixListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedPrefixListAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetManagedPrefixListAssociations">REST API Reference for GetManagedPrefixListAssociations Operation</seealso>
        Task<GetManagedPrefixListAssociationsResponse> GetManagedPrefixListAssociationsAsync(GetManagedPrefixListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedPrefixListEntries



        /// <summary>
        /// Gets information about the entries for a specified managed prefix list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedPrefixListEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedPrefixListEntries service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetManagedPrefixListEntries">REST API Reference for GetManagedPrefixListEntries Operation</seealso>
        Task<GetManagedPrefixListEntriesResponse> GetManagedPrefixListEntriesAsync(GetManagedPrefixListEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNetworkInsightsAccessScopeAnalysisFindings



        /// <summary>
        /// Gets the findings for the specified Network Access Scope analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkInsightsAccessScopeAnalysisFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkInsightsAccessScopeAnalysisFindings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetNetworkInsightsAccessScopeAnalysisFindings">REST API Reference for GetNetworkInsightsAccessScopeAnalysisFindings Operation</seealso>
        Task<GetNetworkInsightsAccessScopeAnalysisFindingsResponse> GetNetworkInsightsAccessScopeAnalysisFindingsAsync(GetNetworkInsightsAccessScopeAnalysisFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNetworkInsightsAccessScopeContent



        /// <summary>
        /// Gets the content for the specified Network Access Scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkInsightsAccessScopeContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkInsightsAccessScopeContent service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetNetworkInsightsAccessScopeContent">REST API Reference for GetNetworkInsightsAccessScopeContent Operation</seealso>
        Task<GetNetworkInsightsAccessScopeContentResponse> GetNetworkInsightsAccessScopeContentAsync(GetNetworkInsightsAccessScopeContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPasswordData



        /// <summary>
        /// Retrieves the encrypted administrator password for a running Windows instance.
        /// 
        ///  
        /// <para>
        /// The Windows password is generated at boot by the <code>EC2Config</code> service or
        /// <code>EC2Launch</code> scripts (Windows Server 2016 and later). This usually only
        /// happens the first time an instance is launched. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/UsingConfig_WinAMI.html">EC2Config</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2launch.html">EC2Launch</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For the <code>EC2Config</code> service, the password is not generated for rebundled
        /// AMIs unless <code>Ec2SetPassword</code> is enabled before bundling.
        /// </para>
        ///  
        /// <para>
        /// The password is encrypted using the key pair that you specified when you launched
        /// the instance. You must provide the corresponding key pair file.
        /// </para>
        ///  
        /// <para>
        /// When you launch an instance, password generation and encryption may take a few minutes.
        /// If you try to retrieve the password before it's available, the output returns an empty
        /// string. We recommend that you wait up to 15 minutes after launching an instance before
        /// trying to retrieve the generated password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReservedInstancesExchangeQuote



        /// <summary>
        /// Returns a quote and exchange information for exchanging one or more specified Convertible
        /// Reserved Instances for a new Convertible Reserved Instance. If the exchange cannot
        /// be performed, the reason is returned in the response. Use <a>AcceptReservedInstancesExchangeQuote</a>
        /// to perform the exchange.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        Task<GetReservedInstancesExchangeQuoteResponse> GetReservedInstancesExchangeQuoteAsync(GetReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSerialConsoleAccessStatus



        /// <summary>
        /// Retrieves the access status of your account to the EC2 serial console of all instances.
        /// By default, access to the EC2 serial console is disabled for your account. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configure-access-to-serial-console.html#serial-console-account-access">Manage
        /// account access to the EC2 serial console</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSerialConsoleAccessStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSerialConsoleAccessStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetSerialConsoleAccessStatus">REST API Reference for GetSerialConsoleAccessStatus Operation</seealso>
        Task<GetSerialConsoleAccessStatusResponse> GetSerialConsoleAccessStatusAsync(GetSerialConsoleAccessStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSpotPlacementScores



        /// <summary>
        /// Calculates the Spot placement score for a Region or Availability Zone based on the
        /// specified target capacity and compute requirements.
        /// 
        ///  
        /// <para>
        /// You can specify your compute requirements either by using <code>InstanceRequirementsWithMetadata</code>
        /// and letting Amazon EC2 choose the optimal instance types to fulfill your Spot request,
        /// or you can specify the instance types by using <code>InstanceTypes</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
        /// placement score</a> in the Amazon EC2 User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpotPlacementScores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpotPlacementScores service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetSpotPlacementScores">REST API Reference for GetSpotPlacementScores Operation</seealso>
        Task<GetSpotPlacementScoresResponse> GetSpotPlacementScoresAsync(GetSpotPlacementScoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubnetCidrReservations



        /// <summary>
        /// Gets information about the subnet CIDR reservations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubnetCidrReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubnetCidrReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetSubnetCidrReservations">REST API Reference for GetSubnetCidrReservations Operation</seealso>
        Task<GetSubnetCidrReservationsResponse> GetSubnetCidrReservationsAsync(GetSubnetCidrReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayAttachmentPropagations



        /// <summary>
        /// Lists the route tables to which the specified resource attachment propagates routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayAttachmentPropagations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayAttachmentPropagations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayAttachmentPropagations">REST API Reference for GetTransitGatewayAttachmentPropagations Operation</seealso>
        Task<GetTransitGatewayAttachmentPropagationsResponse> GetTransitGatewayAttachmentPropagationsAsync(GetTransitGatewayAttachmentPropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayMulticastDomainAssociations



        /// <summary>
        /// Gets information about the associations for the transit gateway multicast domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayMulticastDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayMulticastDomainAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayMulticastDomainAssociations">REST API Reference for GetTransitGatewayMulticastDomainAssociations Operation</seealso>
        Task<GetTransitGatewayMulticastDomainAssociationsResponse> GetTransitGatewayMulticastDomainAssociationsAsync(GetTransitGatewayMulticastDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayPrefixListReferences



        /// <summary>
        /// Gets information about the prefix list references in a specified transit gateway route
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPrefixListReferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayPrefixListReferences service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayPrefixListReferences">REST API Reference for GetTransitGatewayPrefixListReferences Operation</seealso>
        Task<GetTransitGatewayPrefixListReferencesResponse> GetTransitGatewayPrefixListReferencesAsync(GetTransitGatewayPrefixListReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayRouteTableAssociations



        /// <summary>
        /// Gets information about the associations for the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTableAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTableAssociations">REST API Reference for GetTransitGatewayRouteTableAssociations Operation</seealso>
        Task<GetTransitGatewayRouteTableAssociationsResponse> GetTransitGatewayRouteTableAssociationsAsync(GetTransitGatewayRouteTableAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransitGatewayRouteTablePropagations



        /// <summary>
        /// Gets information about the route table propagations for the specified transit gateway
        /// route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTablePropagations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTablePropagations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTablePropagations">REST API Reference for GetTransitGatewayRouteTablePropagations Operation</seealso>
        Task<GetTransitGatewayRouteTablePropagationsResponse> GetTransitGatewayRouteTablePropagationsAsync(GetTransitGatewayRouteTablePropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVpnConnectionDeviceSampleConfiguration



        /// <summary>
        /// Download an Amazon Web Services-provided sample configuration file to be used with
        /// the customer gateway device specified for your Site-to-Site VPN connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpnConnectionDeviceSampleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpnConnectionDeviceSampleConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetVpnConnectionDeviceSampleConfiguration">REST API Reference for GetVpnConnectionDeviceSampleConfiguration Operation</seealso>
        Task<GetVpnConnectionDeviceSampleConfigurationResponse> GetVpnConnectionDeviceSampleConfigurationAsync(GetVpnConnectionDeviceSampleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVpnConnectionDeviceTypes



        /// <summary>
        /// Obtain a list of customer gateway devices for which sample configuration files can
        /// be provided. The request has no additional parameters. You can also see the list of
        /// device types with sample configuration files available under <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/your-cgw.html">Your
        /// customer gateway device</a> in the <i>Amazon Web Services Site-to-Site VPN User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpnConnectionDeviceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpnConnectionDeviceTypes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetVpnConnectionDeviceTypes">REST API Reference for GetVpnConnectionDeviceTypes Operation</seealso>
        Task<GetVpnConnectionDeviceTypesResponse> GetVpnConnectionDeviceTypesAsync(GetVpnConnectionDeviceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportClientVpnClientCertificateRevocationList



        /// <summary>
        /// Uploads a client certificate revocation list to the specified Client VPN endpoint.
        /// Uploading a client certificate revocation list overwrites the existing client certificate
        /// revocation list.
        /// 
        ///  
        /// <para>
        /// Uploading a client certificate revocation list resets existing client connections.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportClientVpnClientCertificateRevocationList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportClientVpnClientCertificateRevocationList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportClientVpnClientCertificateRevocationList">REST API Reference for ImportClientVpnClientCertificateRevocationList Operation</seealso>
        Task<ImportClientVpnClientCertificateRevocationListResponse> ImportClientVpnClientCertificateRevocationListAsync(ImportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportImage



        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
        /// a VM as an image using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportInstance



        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image.
        /// 
        ///  
        /// <para>
        /// This API action supports only single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// This API action is not supported by the Command Line Interface (CLI). For information
        /// about using the Amazon EC2 CLI, which is deprecated, see <a href="https://awsdocs.s3.amazonaws.com/EC2/ec2-clt.pdf#UsingVirtualMachinesinAmazonEC2">Importing
        /// a VM to Amazon EC2</a> in the <i>Amazon EC2 CLI Reference</i> PDF file.
        /// </para>
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportKeyPair



        /// <summary>
        /// Imports the public key from an RSA or ED25519 key pair that you created with a third-party
        /// tool. Compare this with <a>CreateKeyPair</a>, in which Amazon Web Services creates
        /// the key pair and gives the keys to you (Amazon Web Services keeps a copy of the public
        /// key). With ImportKeyPair, you create the key pair and give Amazon Web Services just
        /// the public key. The private key is never transferred between you and Amazon Web Services.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportSnapshot



        /// <summary>
        /// Imports a disk into an EBS snapshot.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-import-snapshot.html">Importing
        /// a disk as a snapshot using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportVolume



        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image.
        /// 
        ///  
        /// <para>
        /// This API action supports only single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>
        /// instead. To import a disk to a snapshot, use <a>ImportSnapshot</a> instead.
        /// </para>
        ///  
        /// <para>
        /// This API action is not supported by the Command Line Interface (CLI). For information
        /// about using the Amazon EC2 CLI, which is deprecated, see <a href="https://awsdocs.s3.amazonaws.com/EC2/ec2-clt.pdf#importing-your-volumes-into-amazon-ebs">Importing
        /// Disks to Amazon EBS</a> in the <i>Amazon EC2 CLI Reference</i> PDF file.
        /// </para>
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSnapshotsInRecycleBin



        /// <summary>
        /// Lists one or more snapshots that are currently in the Recycle Bin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotsInRecycleBin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshotsInRecycleBin service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ListSnapshotsInRecycleBin">REST API Reference for ListSnapshotsInRecycleBin Operation</seealso>
        Task<ListSnapshotsInRecycleBinResponse> ListSnapshotsInRecycleBinAsync(ListSnapshotsInRecycleBinRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyAddressAttribute



        /// <summary>
        /// Modifies an attribute of the specified Elastic IP address. For requirements, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html#Using_Elastic_Addressing_Reverse_DNS">Using
        /// reverse DNS for email applications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAddressAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyAddressAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyAddressAttribute">REST API Reference for ModifyAddressAttribute Operation</seealso>
        Task<ModifyAddressAttributeResponse> ModifyAddressAttributeAsync(ModifyAddressAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyAvailabilityZoneGroup



        /// <summary>
        /// Changes the opt-in status of the Local Zone and Wavelength Zone group for your account.
        /// 
        ///  
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeAvailabilityZones.html">
        /// DescribeAvailabilityZones</a> to view the value for <code>GroupName</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAvailabilityZoneGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyAvailabilityZoneGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyAvailabilityZoneGroup">REST API Reference for ModifyAvailabilityZoneGroup Operation</seealso>
        Task<ModifyAvailabilityZoneGroupResponse> ModifyAvailabilityZoneGroupAsync(ModifyAvailabilityZoneGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCapacityReservation



        /// <summary>
        /// Modifies a Capacity Reservation's capacity and the conditions under which it is to
        /// be released. You cannot change a Capacity Reservation's instance type, EBS optimization,
        /// instance store settings, platform, Availability Zone, or instance eligibility. If
        /// you need to modify any of these attributes, we recommend that you cancel the Capacity
        /// Reservation, and then create a new one with the required attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCapacityReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        Task<ModifyCapacityReservationResponse> ModifyCapacityReservationAsync(ModifyCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCapacityReservationFleet



        /// <summary>
        /// Modifies a Capacity Reservation Fleet.
        /// 
        ///  
        /// <para>
        /// When you modify the total target capacity of a Capacity Reservation Fleet, the Fleet
        /// automatically creates new Capacity Reservations, or modifies or cancels existing Capacity
        /// Reservations in the Fleet to meet the new total target capacity. When you modify the
        /// end date for the Fleet, the end dates for all of the individual Capacity Reservations
        /// in the Fleet are updated accordingly.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservationFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCapacityReservationFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyCapacityReservationFleet">REST API Reference for ModifyCapacityReservationFleet Operation</seealso>
        Task<ModifyCapacityReservationFleetResponse> ModifyCapacityReservationFleetAsync(ModifyCapacityReservationFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClientVpnEndpoint



        /// <summary>
        /// Modifies the specified Client VPN endpoint. Modifying the DNS server resets existing
        /// client connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientVpnEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClientVpnEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyClientVpnEndpoint">REST API Reference for ModifyClientVpnEndpoint Operation</seealso>
        Task<ModifyClientVpnEndpointResponse> ModifyClientVpnEndpointAsync(ModifyClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDefaultCreditSpecification



        /// <summary>
        /// Modifies the default credit option for CPU usage of burstable performance instances.
        /// The default credit option is set at the account level per Amazon Web Services Region,
        /// and is specified per instance family. All new burstable performance instances in the
        /// account launch using the default credit option.
        /// 
        ///  
        /// <para>
        ///  <code>ModifyDefaultCreditSpecification</code> is an asynchronous operation, which
        /// works at an Amazon Web Services Region level and modifies the credit option for each
        /// Availability Zone. All zones in a Region are updated within five minutes. But if instances
        /// are launched during this operation, they might not get the new credit option until
        /// the zone is updated. To verify whether the update has occurred, you can call <code>GetDefaultCreditSpecification</code>
        /// and check <code>DefaultCreditSpecification</code> for updates.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDefaultCreditSpecification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDefaultCreditSpecification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyDefaultCreditSpecification">REST API Reference for ModifyDefaultCreditSpecification Operation</seealso>
        Task<ModifyDefaultCreditSpecificationResponse> ModifyDefaultCreditSpecificationAsync(ModifyDefaultCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEbsDefaultKmsKeyId



        /// <summary>
        /// Changes the default KMS key for EBS encryption by default for your account in this
        /// Region.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services creates a unique Amazon Web Services managed KMS key in each Region
        /// for use with encryption by default. If you change the default KMS key to a symmetric
        /// customer managed KMS key, it is used instead of the Amazon Web Services managed KMS
        /// key. To reset the default KMS key to the Amazon Web Services managed KMS key for EBS,
        /// use <a>ResetEbsDefaultKmsKeyId</a>. Amazon EBS does not support asymmetric KMS keys.
        /// </para>
        ///  
        /// <para>
        /// If you delete or disable the customer managed KMS key that you specified for use with
        /// encryption by default, your instances will fail to launch.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyEbsDefaultKmsKeyId">REST API Reference for ModifyEbsDefaultKmsKeyId Operation</seealso>
        Task<ModifyEbsDefaultKmsKeyIdResponse> ModifyEbsDefaultKmsKeyIdAsync(ModifyEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyFleet



        /// <summary>
        /// Modifies the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// You can only modify an EC2 Fleet request of type <code>maintain</code>.
        /// </para>
        ///  
        /// <para>
        /// While the EC2 Fleet is being modified, it is in the <code>modifying</code> state.
        /// </para>
        ///  
        /// <para>
        /// To scale up your EC2 Fleet, increase its target capacity. The EC2 Fleet launches the
        /// additional Spot Instances according to the allocation strategy for the EC2 Fleet request.
        /// If the allocation strategy is <code>lowest-price</code>, the EC2 Fleet launches instances
        /// using the Spot Instance pool with the lowest price. If the allocation strategy is
        /// <code>diversified</code>, the EC2 Fleet distributes the instances across the Spot
        /// Instance pools. If the allocation strategy is <code>capacity-optimized</code>, EC2
        /// Fleet launches instances from Spot Instance pools with optimal capacity for the number
        /// of instances that are launching.
        /// </para>
        ///  
        /// <para>
        /// To scale down your EC2 Fleet, decrease its target capacity. First, the EC2 Fleet cancels
        /// any open requests that exceed the new target capacity. You can request that the EC2
        /// Fleet terminate Spot Instances until the size of the fleet no longer exceeds the new
        /// target capacity. If the allocation strategy is <code>lowest-price</code>, the EC2
        /// Fleet terminates the instances with the highest price per unit. If the allocation
        /// strategy is <code>capacity-optimized</code>, the EC2 Fleet terminates the instances
        /// in the Spot Instance pools that have the least available Spot Instance capacity. If
        /// the allocation strategy is <code>diversified</code>, the EC2 Fleet terminates instances
        /// across the Spot Instance pools. Alternatively, you can request that the EC2 Fleet
        /// keep the fleet at its current size, but not replace any Spot Instances that are interrupted
        /// or that you terminate manually.
        /// </para>
        ///  
        /// <para>
        /// If you are finished with your EC2 Fleet for now, but will use it again later, you
        /// can set the target capacity to 0.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        Task<ModifyFleetResponse> ModifyFleetAsync(ModifyFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyFpgaImageAttribute



        /// <summary>
        /// Modifies the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        Task<ModifyFpgaImageAttributeResponse> ModifyFpgaImageAttributeAsync(ModifyFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyHosts



        /// <summary>
        /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
        /// any instances that you launch with a tenancy of <code>host</code> but without a specific
        /// host ID are placed onto any available Dedicated Host in your account that has auto-placement
        /// enabled. When auto-placement is disabled, you need to provide a host ID to have the
        /// instance launch onto a specific host. If no host ID is provided, the instance is launched
        /// onto a suitable host with auto-placement enabled.
        /// 
        ///  
        /// <para>
        /// You can also use this API action to modify a Dedicated Host to support either multiple
        /// instance types in an instance family, or to support a specific instance type only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        Task<ModifyHostsResponse> ModifyHostsAsync(ModifyHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIdentityIdFormat



        /// <summary>
        /// Modifies the ID format of a resource for a specified IAM user, IAM role, or the root
        /// user for an account; or all IAM users, IAM roles, and the root user for an account.
        /// You can specify that resources should receive longer IDs (17-character IDs) when they
        /// are created. 
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the principal specified in the request; it does not apply
        /// to the principal that makes the request. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        Task<ModifyIdentityIdFormatResponse> ModifyIdentityIdFormatAsync(ModifyIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIdFormat



        /// <summary>
        /// Modifies the ID format for the specified resource on a per-Region basis. You can specify
        /// that resources should receive longer IDs (17-character IDs) when they are created.
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the IAM user who makes the request; it does not apply to the
        /// entire Amazon Web Services account. By default, an IAM user defaults to the same settings
        /// as the root user. If you're using this action as the root user, then these settings
        /// apply to the entire account, unless an IAM user explicitly overrides these settings
        /// for themselves. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        Task<ModifyIdFormatResponse> ModifyIdFormatAsync(ModifyIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyImageAttribute



        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time. You can use the <code>Attribute</code> parameter to specify the attribute
        /// or one of the following parameters: <code>Description</code> or <code>LaunchPermission</code>.
        /// 
        ///  
        /// <para>
        /// Images with an Amazon Web Services Marketplace product code cannot be made public.
        /// </para>
        ///  
        /// <para>
        /// To enable the SriovNetSupport enhanced networking attribute of an image, enable SriovNetSupport
        /// on an instance and create an AMI from the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceAttribute



        /// <summary>
        /// Modifies the specified attribute of the specified instance. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        ///  <b>Note: </b>Using this action to change the security groups associated with an elastic
        /// network interface (ENI) attached to an instance in a VPC can result in an error if
        /// the instance has more than one ENI. To change the security groups associated with
        /// an ENI attached to an instance that has multiple ENIs, we recommend that you use the
        /// <a>ModifyNetworkInterfaceAttribute</a> action.
        /// </para>
        ///  
        /// <para>
        /// To modify some attributes, the instance must be stopped. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modify
        /// a stopped instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceCapacityReservationAttributes



        /// <summary>
        /// Modifies the Capacity Reservation settings for a stopped instance. Use this action
        /// to configure an instance to target a specific Capacity Reservation, run in any <code>open</code>
        /// Capacity Reservation with matching attributes, or run On-Demand Instance capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCapacityReservationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceCapacityReservationAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCapacityReservationAttributes">REST API Reference for ModifyInstanceCapacityReservationAttributes Operation</seealso>
        Task<ModifyInstanceCapacityReservationAttributesResponse> ModifyInstanceCapacityReservationAttributesAsync(ModifyInstanceCapacityReservationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceCreditSpecification



        /// <summary>
        /// Modifies the credit option for CPU usage on a running or stopped burstable performance
        /// instance. The credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceCreditSpecification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        Task<ModifyInstanceCreditSpecificationResponse> ModifyInstanceCreditSpecificationAsync(ModifyInstanceCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceEventStartTime



        /// <summary>
        /// Modifies the start time for a scheduled Amazon EC2 instance event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceEventStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceEventStartTime service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceEventStartTime">REST API Reference for ModifyInstanceEventStartTime Operation</seealso>
        Task<ModifyInstanceEventStartTimeResponse> ModifyInstanceEventStartTimeAsync(ModifyInstanceEventStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceEventWindow



        /// <summary>
        /// Modifies the specified event window.
        /// 
        ///  
        /// <para>
        /// You can define either a set of time ranges or a cron expression when modifying the
        /// event window, but not both.
        /// </para>
        ///  
        /// <para>
        /// To modify the targets associated with the event window, use the <a>AssociateInstanceEventWindow</a>
        /// and <a>DisassociateInstanceEventWindow</a> API.
        /// </para>
        ///  
        /// <para>
        /// If Amazon Web Services has already scheduled an event, modifying an event window won't
        /// change the time of the scheduled event.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
        /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceEventWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceEventWindow service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceEventWindow">REST API Reference for ModifyInstanceEventWindow Operation</seealso>
        Task<ModifyInstanceEventWindowResponse> ModifyInstanceEventWindowAsync(ModifyInstanceEventWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstanceMetadataOptions



        /// <summary>
        /// Modify the instance metadata parameters on a running or stopped instance. When you
        /// modify the parameters on a stopped instance, they are applied when the instance is
        /// started. When you modify the parameters on a running instance, the API responds with
        /// a state of “pending”. After the parameter modifications are successfully applied to
        /// the instance, the state of the modifications changes from “pending” to “applied” in
        /// subsequent describe-instances API calls. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceMetadataOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceMetadataOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceMetadataOptions">REST API Reference for ModifyInstanceMetadataOptions Operation</seealso>
        Task<ModifyInstanceMetadataOptionsResponse> ModifyInstanceMetadataOptionsAsync(ModifyInstanceMetadataOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyInstancePlacement



        /// <summary>
        /// Modifies the placement attributes for a specified instance. You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Modify the affinity between an instance and a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Host</a>. When affinity is set to <code>host</code> and the instance is not associated
        /// with a specific Dedicated Host, the next time the instance is launched, it is automatically
        /// associated with the host on which it lands. If the instance is restarted or rebooted,
        /// this relationship persists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the Dedicated Host with which an instance is associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the instance tenancy of an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Move an instance to or from a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">placement
        /// group</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At least one attribute for affinity, host ID, tenancy, or placement group name must
        /// be specified in the request. Affinity and tenancy can be modified in the same request.
        /// </para>
        ///  
        /// <para>
        /// To modify the host ID, tenancy, placement group, or partition for an instance, the
        /// instance must be in the <code>stopped</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstancePlacement service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        Task<ModifyInstancePlacementResponse> ModifyInstancePlacementAsync(ModifyInstancePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIpam



        /// <summary>
        /// Modify the configurations of an IPAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIpam service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIpam">REST API Reference for ModifyIpam Operation</seealso>
        Task<ModifyIpamResponse> ModifyIpamAsync(ModifyIpamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIpamPool



        /// <summary>
        /// Modify the configurations of an IPAM pool.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/mod-pool-ipam.html">Modify a pool</a>
        /// in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpamPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIpamPool service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIpamPool">REST API Reference for ModifyIpamPool Operation</seealso>
        Task<ModifyIpamPoolResponse> ModifyIpamPoolAsync(ModifyIpamPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIpamResourceCidr



        /// <summary>
        /// Modify a resource CIDR. You can use this action to transfer resource CIDRs between
        /// scopes and ignore resource CIDRs that you do not want to manage. If set to false,
        /// the resource will not be tracked for overlap, it cannot be auto-imported into a pool,
        /// and it will be removed from any pool it has an allocation in.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/move-resource-ipam.html">Move
        /// resource CIDRs between scopes</a> and <a href="/vpc/latest/ipam/change-monitoring-state-ipam.html">Change
        /// the monitoring state of resource CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpamResourceCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIpamResourceCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIpamResourceCidr">REST API Reference for ModifyIpamResourceCidr Operation</seealso>
        Task<ModifyIpamResourceCidrResponse> ModifyIpamResourceCidrAsync(ModifyIpamResourceCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyIpamScope



        /// <summary>
        /// Modify an IPAM scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpamScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIpamScope service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIpamScope">REST API Reference for ModifyIpamScope Operation</seealso>
        Task<ModifyIpamScopeResponse> ModifyIpamScopeAsync(ModifyIpamScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyLaunchTemplate



        /// <summary>
        /// Modifies a launch template. You can specify which version of the launch template to
        /// set as the default version. When launching an instance, the default version applies
        /// when a launch template version is not specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        Task<ModifyLaunchTemplateResponse> ModifyLaunchTemplateAsync(ModifyLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyManagedPrefixList



        /// <summary>
        /// Modifies the specified managed prefix list.
        /// 
        ///  
        /// <para>
        /// Adding or removing entries in a prefix list creates a new version of the prefix list.
        /// Changing the name of the prefix list does not affect the version.
        /// </para>
        ///  
        /// <para>
        /// If you specify a current version number that does not match the true current version
        /// number, the request fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyManagedPrefixList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyManagedPrefixList service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyManagedPrefixList">REST API Reference for ModifyManagedPrefixList Operation</seealso>
        Task<ModifyManagedPrefixListResponse> ModifyManagedPrefixListAsync(ModifyManagedPrefixListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyNetworkInterfaceAttribute



        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time. You can use this action to attach and detach security groups from an existing
        /// EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyPrivateDnsNameOptions



        /// <summary>
        /// Modifies the options for instance hostnames for the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyPrivateDnsNameOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyPrivateDnsNameOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyPrivateDnsNameOptions">REST API Reference for ModifyPrivateDnsNameOptions Operation</seealso>
        Task<ModifyPrivateDnsNameOptionsResponse> ModifyPrivateDnsNameOptionsAsync(ModifyPrivateDnsNameOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReservedInstances



        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
        /// modified must be identical, except for Availability Zone, network platform, and instance
        /// type.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySecurityGroupRules



        /// <summary>
        /// Modifies the rules of a security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySecurityGroupRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySecurityGroupRules service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySecurityGroupRules">REST API Reference for ModifySecurityGroupRules Operation</seealso>
        Task<ModifySecurityGroupRulesResponse> ModifySecurityGroupRulesAsync(ModifySecurityGroupRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySnapshotAttribute



        /// <summary>
        /// Adds or removes permission settings for the specified snapshot. You may add or remove
        /// specified Amazon Web Services account IDs from a snapshot's list of create volume
        /// permissions, but you cannot do both in a single operation. If you need to both add
        /// and remove account IDs for a snapshot, you must use multiple operations. You can make
        /// up to 500 modifications to a snapshot in a single operation.
        /// 
        ///  
        /// <para>
        /// Encrypted snapshots and snapshots with Amazon Web Services Marketplace product codes
        /// cannot be made public. Snapshots encrypted with your default KMS key cannot be shared
        /// with other accounts.
        /// </para>
        ///  
        /// <para>
        /// For more information about modifying snapshot permissions, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Share
        /// a snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySnapshotTier



        /// <summary>
        /// Archives an Amazon EBS snapshot. When you archive a snapshot, it is converted to a
        /// full snapshot that includes all of the blocks of data that were written to the volume
        /// at the time the snapshot was created, and moved from the standard tier to the archive
        /// tier. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-archive.html">Archive
        /// Amazon EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotTier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotTier service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotTier">REST API Reference for ModifySnapshotTier Operation</seealso>
        Task<ModifySnapshotTierResponse> ModifySnapshotTierAsync(ModifySnapshotTierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySpotFleetRequest



        /// <summary>
        /// Modifies the specified Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// You can only modify a Spot Fleet request of type <code>maintain</code>.
        /// </para>
        ///  
        /// <para>
        /// While the Spot Fleet request is being modified, it is in the <code>modifying</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// To scale up your Spot Fleet, increase its target capacity. The Spot Fleet launches
        /// the additional Spot Instances according to the allocation strategy for the Spot Fleet
        /// request. If the allocation strategy is <code>lowestPrice</code>, the Spot Fleet launches
        /// instances using the Spot Instance pool with the lowest price. If the allocation strategy
        /// is <code>diversified</code>, the Spot Fleet distributes the instances across the Spot
        /// Instance pools. If the allocation strategy is <code>capacityOptimized</code>, Spot
        /// Fleet launches instances from Spot Instance pools with optimal capacity for the number
        /// of instances that are launching.
        /// </para>
        ///  
        /// <para>
        /// To scale down your Spot Fleet, decrease its target capacity. First, the Spot Fleet
        /// cancels any open requests that exceed the new target capacity. You can request that
        /// the Spot Fleet terminate Spot Instances until the size of the fleet no longer exceeds
        /// the new target capacity. If the allocation strategy is <code>lowestPrice</code>, the
        /// Spot Fleet terminates the instances with the highest price per unit. If the allocation
        /// strategy is <code>capacityOptimized</code>, the Spot Fleet terminates the instances
        /// in the Spot Instance pools that have the least available Spot Instance capacity. If
        /// the allocation strategy is <code>diversified</code>, the Spot Fleet terminates instances
        /// across the Spot Instance pools. Alternatively, you can request that the Spot Fleet
        /// keep the fleet at its current size, but not replace any Spot Instances that are interrupted
        /// or that you terminate manually.
        /// </para>
        ///  
        /// <para>
        /// If you are finished with your Spot Fleet for now, but will use it again later, you
        /// can set the target capacity to 0.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySpotFleetRequest service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySubnetAttribute



        /// <summary>
        /// Modifies a subnet attribute. You can only modify one attribute at a time.
        /// 
        ///  
        /// <para>
        /// Use this action to modify subnets on Amazon Web Services Outposts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To modify a subnet on an Outpost rack, set both <code>MapCustomerOwnedIpOnLaunch</code>
        /// and <code>CustomerOwnedIpv4Pool</code>. These two parameters act as a single attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To modify a subnet on an Outpost server, set either <code>EnableLniAtDeviceIndex</code>
        /// or <code>DisableLniAtDeviceIndex</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Amazon Web Services Outposts, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/outposts/latest/userguide/how-servers-work.html">Outpost
        /// servers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/outposts/latest/userguide/how-racks-work.html">Outpost
        /// racks</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTrafficMirrorFilterNetworkServices



        /// <summary>
        /// Allows or restricts mirroring network services.
        /// 
        ///  
        /// <para>
        ///  By default, Amazon DNS network services are not eligible for Traffic Mirror. Use
        /// <code>AddNetworkServices</code> to add network services to a Traffic Mirror filter.
        /// When a network service is added to the Traffic Mirror filter, all traffic related
        /// to that network service will be mirrored. When you no longer want to mirror network
        /// services, use <code>RemoveNetworkServices</code> to remove the network services from
        /// the Traffic Mirror filter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTrafficMirrorFilterNetworkServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTrafficMirrorFilterNetworkServices service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTrafficMirrorFilterNetworkServices">REST API Reference for ModifyTrafficMirrorFilterNetworkServices Operation</seealso>
        Task<ModifyTrafficMirrorFilterNetworkServicesResponse> ModifyTrafficMirrorFilterNetworkServicesAsync(ModifyTrafficMirrorFilterNetworkServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTrafficMirrorFilterRule



        /// <summary>
        /// Modifies the specified Traffic Mirror rule.
        /// 
        ///  
        /// <para>
        ///  <code>DestinationCidrBlock</code> and <code>SourceCidrBlock</code> must both be an
        /// IPv4 range or an IPv6 range.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTrafficMirrorFilterRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTrafficMirrorFilterRule service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTrafficMirrorFilterRule">REST API Reference for ModifyTrafficMirrorFilterRule Operation</seealso>
        Task<ModifyTrafficMirrorFilterRuleResponse> ModifyTrafficMirrorFilterRuleAsync(ModifyTrafficMirrorFilterRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTrafficMirrorSession



        /// <summary>
        /// Modifies a Traffic Mirror session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTrafficMirrorSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTrafficMirrorSession service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTrafficMirrorSession">REST API Reference for ModifyTrafficMirrorSession Operation</seealso>
        Task<ModifyTrafficMirrorSessionResponse> ModifyTrafficMirrorSessionAsync(ModifyTrafficMirrorSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTransitGateway



        /// <summary>
        /// Modifies the specified transit gateway. When you modify a transit gateway, the modified
        /// options are applied to new transit gateway attachments only. Your existing transit
        /// gateway attachments are not modified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTransitGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTransitGateway">REST API Reference for ModifyTransitGateway Operation</seealso>
        Task<ModifyTransitGatewayResponse> ModifyTransitGatewayAsync(ModifyTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTransitGatewayPrefixListReference



        /// <summary>
        /// Modifies a reference (route) to a prefix list in a specified transit gateway route
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTransitGatewayPrefixListReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTransitGatewayPrefixListReference service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTransitGatewayPrefixListReference">REST API Reference for ModifyTransitGatewayPrefixListReference Operation</seealso>
        Task<ModifyTransitGatewayPrefixListReferenceResponse> ModifyTransitGatewayPrefixListReferenceAsync(ModifyTransitGatewayPrefixListReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTransitGatewayVpcAttachment



        /// <summary>
        /// Modifies the specified VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTransitGatewayVpcAttachment">REST API Reference for ModifyTransitGatewayVpcAttachment Operation</seealso>
        Task<ModifyTransitGatewayVpcAttachmentResponse> ModifyTransitGatewayVpcAttachmentAsync(ModifyTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVolume



        /// <summary>
        /// You can modify several parameters of an existing EBS volume, including volume size,
        /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
        /// EC2 instance type, you might be able to apply these changes without stopping the instance
        /// or detaching the volume from it. For more information about modifying EBS volumes,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modify-volume.html">Amazon
        /// EBS Elastic Volumes</a> (Linux instances) or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-modify-volume.html">Amazon
        /// EBS Elastic Volumes</a> (Windows instances).
        /// 
        ///  
        /// <para>
        /// When you complete a resize operation on your volume, you need to extend the volume's
        /// file-system size to take advantage of the new storage capacity. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extend
        /// a Linux file system</a> or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extend
        /// a Windows file system</a>.
        /// </para>
        ///  
        /// <para>
        ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
        /// For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. You can also track the status of a modification
        /// using <a>DescribeVolumesModifications</a>. For information about tracking status changes
        /// using either method, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-modifications.html">Monitor
        /// the progress of volume modifications</a>.
        /// </para>
        ///  
        /// <para>
        /// With previous-generation instance types, resizing an EBS volume might require detaching
        /// and reattaching the volume or stopping and restarting the instance.
        /// </para>
        ///  
        /// <para>
        /// If you reach the maximum volume modification rate per volume limit, you must wait
        /// at least six hours before applying further modifications to the affected EBS volume.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        Task<ModifyVolumeResponse> ModifyVolumeAsync(ModifyVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVolumeAttribute



        /// <summary>
        /// Modifies a volume attribute.
        /// 
        ///  
        /// <para>
        /// By default, all I/O operations for the volume are suspended when the data on the volume
        /// is determined to be potentially inconsistent, to prevent undetectable, latent data
        /// corruption. The I/O access to the volume can be resumed by first enabling I/O access
        /// and then checking the data consistency on your volume.
        /// </para>
        ///  
        /// <para>
        /// You can change the default behavior to resume I/O operations. We recommend that you
        /// change this only for boot volumes or for volumes that are stateless or disposable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcAttribute



        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcEndpoint



        /// <summary>
        /// Modifies attributes of a specified VPC endpoint. The attributes that you can modify
        /// depend on the type of VPC endpoint (interface, gateway, or Gateway Load Balancer).
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcEndpointConnectionNotification



        /// <summary>
        /// Modifies a connection notification for VPC endpoint or VPC endpoint service. You can
        /// change the SNS topic for the notification, or the events for which to be notified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        Task<ModifyVpcEndpointConnectionNotificationResponse> ModifyVpcEndpointConnectionNotificationAsync(ModifyVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcEndpointServiceConfiguration



        /// <summary>
        /// Modifies the attributes of your VPC endpoint service configuration. You can change
        /// the Network Load Balancers or Gateway Load Balancers for your service, and you can
        /// specify whether acceptance is required for requests to connect to your endpoint service
        /// through an interface VPC endpoint.
        /// 
        ///  
        /// <para>
        /// If you set or modify the private DNS name, you must prove that you own the private
        /// DNS domain name. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-services-dns-validation.html">VPC
        /// Endpoint Service Private DNS Name Verification</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        Task<ModifyVpcEndpointServiceConfigurationResponse> ModifyVpcEndpointServiceConfigurationAsync(ModifyVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcEndpointServicePermissions



        /// <summary>
        /// Modifies the permissions for your <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-service.html">VPC
        /// endpoint service</a>. You can add or remove permissions for service consumers (IAM
        /// users, IAM roles, and Amazon Web Services accounts) to connect to your endpoint service.
        /// 
        ///  
        /// <para>
        /// If you grant permissions to all principals, the service is public. Any users who know
        /// the name of a public service can send a request to attach an endpoint. If the service
        /// does not require manual approval, attachments are automatically approved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        Task<ModifyVpcEndpointServicePermissionsResponse> ModifyVpcEndpointServicePermissionsAsync(ModifyVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcPeeringConnectionOptions



        /// <summary>
        /// Modifies the VPC peering connection options on one side of a VPC peering connection.
        /// You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between an EC2-Classic instance
        /// that's linked to your VPC (using ClassicLink) and instances in the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between instances in your
        /// VPC and an EC2-Classic instance that's linked to the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable the ability to resolve public DNS hostnames to private IP addresses
        /// when queried from instances in the peer VPC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the peered VPCs are in the same Amazon Web Services account, you can enable DNS
        /// resolution for queries from the local VPC. This ensures that queries from the local
        /// VPC resolve to private IP addresses in the peer VPC. This option is not available
        /// if the peered VPCs are in different different Amazon Web Services accounts or different
        /// Regions. For peered VPCs in different Amazon Web Services accounts, each Amazon Web
        /// Services account owner must initiate a separate request to modify the peering connection
        /// options. For inter-region peering connections, you must use the Region for the requester
        /// VPC to modify the requester VPC peering options and the Region for the accepter VPC
        /// to modify the accepter VPC peering options. To verify which VPCs are the accepter
        /// and the requester for a VPC peering connection, use the <a>DescribeVpcPeeringConnections</a>
        /// command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcPeeringConnectionOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        Task<ModifyVpcPeeringConnectionOptionsResponse> ModifyVpcPeeringConnectionOptionsAsync(ModifyVpcPeeringConnectionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpcTenancy



        /// <summary>
        /// Modifies the instance tenancy attribute of the specified VPC. You can change the instance
        /// tenancy attribute of a VPC to <code>default</code> only. You cannot change the instance
        /// tenancy attribute to <code>dedicated</code>.
        /// 
        ///  
        /// <para>
        /// After you modify the tenancy of the VPC, any new instances that you launch into the
        /// VPC have a tenancy of <code>default</code>, unless you specify otherwise during launch.
        /// The tenancy of any existing instances in the VPC is not affected.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpcTenancy service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        Task<ModifyVpcTenancyResponse> ModifyVpcTenancyAsync(ModifyVpcTenancyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpnConnection



        /// <summary>
        /// Modifies the customer gateway or the target gateway of an Amazon Web Services Site-to-Site
        /// VPN connection. To modify the target gateway, the following migration options are
        /// available:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An existing virtual private gateway to a new virtual private gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing virtual private gateway to a transit gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing transit gateway to a new transit gateway
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An existing transit gateway to a virtual private gateway
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you perform the migration to the new gateway, you must configure the new gateway.
        /// Use <a>CreateVpnGateway</a> to create a virtual private gateway, or <a>CreateTransitGateway</a>
        /// to create a transit gateway.
        /// </para>
        ///  
        /// <para>
        /// This step is required when you migrate from a virtual private gateway with static
        /// routes to a transit gateway. 
        /// </para>
        ///  
        /// <para>
        /// You must delete the static routes before you migrate to the new gateway.
        /// </para>
        ///  
        /// <para>
        /// Keep a copy of the static route before you delete it. You will need to add back these
        /// routes to the transit gateway after the VPN connection migration is complete.
        /// </para>
        ///  
        /// <para>
        /// After you migrate to the new gateway, you might need to modify your VPC route table.
        /// Use <a>CreateRoute</a> and <a>DeleteRoute</a> to make the changes described in <a
        /// href="https://docs.aws.amazon.com/vpn/latest/s2svpn/modify-vpn-target.html#step-update-routing">Update
        /// VPC route tables</a> in the <i>Amazon Web Services Site-to-Site VPN User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the new gateway is a transit gateway, modify the transit gateway route table
        /// to allow traffic between the VPC and the Amazon Web Services Site-to-Site VPN connection.
        /// Use <a>CreateTransitGatewayRoute</a> to add the routes.
        /// </para>
        ///  
        /// <para>
        ///  If you deleted VPN static routes, you must add the static routes to the transit gateway
        /// route table.
        /// </para>
        ///  
        /// <para>
        /// After you perform this operation, the VPN endpoint's IP addresses on the Amazon Web
        /// Services side and the tunnel options remain intact. Your Amazon Web Services Site-to-Site
        /// VPN connection will be temporarily unavailable for a brief period while we provision
        /// the new endpoints.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpnConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpnConnection">REST API Reference for ModifyVpnConnection Operation</seealso>
        Task<ModifyVpnConnectionResponse> ModifyVpnConnectionAsync(ModifyVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpnConnectionOptions



        /// <summary>
        /// Modifies the connection options for your Site-to-Site VPN connection.
        /// 
        ///  
        /// <para>
        /// When you modify the VPN connection options, the VPN endpoint IP addresses on the Amazon
        /// Web Services side do not change, and the tunnel options do not change. Your VPN connection
        /// will be temporarily unavailable for a brief period while the VPN connection is updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpnConnectionOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpnConnectionOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpnConnectionOptions">REST API Reference for ModifyVpnConnectionOptions Operation</seealso>
        Task<ModifyVpnConnectionOptionsResponse> ModifyVpnConnectionOptionsAsync(ModifyVpnConnectionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpnTunnelCertificate



        /// <summary>
        /// Modifies the VPN tunnel endpoint certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpnTunnelCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpnTunnelCertificate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpnTunnelCertificate">REST API Reference for ModifyVpnTunnelCertificate Operation</seealso>
        Task<ModifyVpnTunnelCertificateResponse> ModifyVpnTunnelCertificateAsync(ModifyVpnTunnelCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyVpnTunnelOptions



        /// <summary>
        /// Modifies the options for a VPN tunnel in an Amazon Web Services Site-to-Site VPN connection.
        /// You can modify multiple options for a tunnel in a single request, but you can only
        /// modify one tunnel at a time. For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPNTunnels.html">Site-to-Site
        /// VPN tunnel options for your Site-to-Site VPN connection</a> in the <i>Amazon Web Services
        /// Site-to-Site VPN User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpnTunnelOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyVpnTunnelOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpnTunnelOptions">REST API Reference for ModifyVpnTunnelOptions Operation</seealso>
        Task<ModifyVpnTunnelOptionsResponse> ModifyVpnTunnelOptionsAsync(ModifyVpnTunnelOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MonitorInstances



        /// <summary>
        /// Enables detailed monitoring for a running instance. Otherwise, basic monitoring is
        /// enabled. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitor
        /// your instances using CloudWatch</a> in the <i>Amazon EC2 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To disable detailed monitoring, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MoveAddressToVpc



        /// <summary>
        /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
        /// The Elastic IP address must be allocated to your account for more than 24 hours, and
        /// it must not be associated with an instance. After the Elastic IP address is moved,
        /// it is no longer available for use in the EC2-Classic platform, unless you move it
        /// back using the <a>RestoreAddressToClassic</a> request. You cannot move an Elastic
        /// IP address that was originally allocated for use in the EC2-VPC platform to the EC2-Classic
        /// platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MoveAddressToVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MoveByoipCidrToIpam



        /// <summary>
        /// Move an BYOIP IPv4 CIDR to IPAM from a public IPv4 pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveByoipCidrToIpam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MoveByoipCidrToIpam service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveByoipCidrToIpam">REST API Reference for MoveByoipCidrToIpam Operation</seealso>
        Task<MoveByoipCidrToIpamResponse> MoveByoipCidrToIpamAsync(MoveByoipCidrToIpamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ProvisionByoipCidr



        /// <summary>
        /// Provisions an IPv4 or IPv6 address range for use with your Amazon Web Services resources
        /// through bring your own IP addresses (BYOIP) and creates a corresponding address pool.
        /// After the address range is provisioned, it is ready to be advertised using <a>AdvertiseByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services verifies that you own the address range and are authorized to
        /// advertise it. You must ensure that the address range is registered to you and that
        /// you created an RPKI ROA to authorize Amazon ASNs 16509 and 14618 to advertise the
        /// address range. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// your own IP addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Provisioning an address range is an asynchronous operation, so the call returns immediately,
        /// but the address range is not ready to use until its status changes from <code>pending-provision</code>
        /// to <code>provisioned</code>. To monitor the status of an address range, use <a>DescribeByoipCidrs</a>.
        /// To allocate an Elastic IP address from your IPv4 address pool, use <a>AllocateAddress</a>
        /// with either the specific address from the address pool or the ID of the address pool.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        Task<ProvisionByoipCidrResponse> ProvisionByoipCidrAsync(ProvisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ProvisionIpamPoolCidr



        /// <summary>
        /// Provision a CIDR to an IPAM pool. You can use thsi action to provision new CIDRs to
        /// a top-level pool or to transfer a CIDR from a top-level pool to a pool within it.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="/vpc/latest/ipam/prov-cidr-ipam.html">Provision
        /// CIDRs to pools</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionIpamPoolCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionIpamPoolCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ProvisionIpamPoolCidr">REST API Reference for ProvisionIpamPoolCidr Operation</seealso>
        Task<ProvisionIpamPoolCidrResponse> ProvisionIpamPoolCidrAsync(ProvisionIpamPoolCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ProvisionPublicIpv4PoolCidr



        /// <summary>
        /// Provision a CIDR to a public IPv4 pool.
        /// 
        ///  
        /// <para>
        /// For more information about IPAM, see <a href="/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPublicIpv4PoolCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionPublicIpv4PoolCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ProvisionPublicIpv4PoolCidr">REST API Reference for ProvisionPublicIpv4PoolCidr Operation</seealso>
        Task<ProvisionPublicIpv4PoolCidrResponse> ProvisionPublicIpv4PoolCidrAsync(ProvisionPublicIpv4PoolCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseHostReservation



        /// <summary>
        /// Purchase a reservation with configurations that match those of your Dedicated Host.
        /// You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// This action results in the specified reservation being purchased and charged to your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseHostReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        Task<PurchaseHostReservationResponse> PurchaseHostReservationAsync(PurchaseHostReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedInstancesOffering



        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
        /// you pay a lower hourly rate compared to On-Demand instance pricing.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
        /// that match your specifications. After you've purchased a Reserved Instance, you can
        /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// To queue a purchase for a future date and time, specify a purchase time. If you do
        /// not specify a purchase time, the default is the current time.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseScheduledInstances



        /// <summary>
        /// Purchases the Scheduled Instances with the specified schedule.
        /// 
        ///  
        /// <para>
        /// Scheduled Instances enable you to purchase Amazon EC2 compute capacity by the hour
        /// for a one-year term. Before you can purchase a Scheduled Instance, you must call <a>DescribeScheduledInstanceAvailability</a>
        /// to check for available schedules and obtain a purchase token. After you purchase a
        /// Scheduled Instance, you must call <a>RunScheduledInstances</a> during each scheduled
        /// time period.
        /// </para>
        ///  
        /// <para>
        /// After you purchase a Scheduled Instance, you can't cancel, modify, or resell your
        /// purchase.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        Task<PurchaseScheduledInstancesResponse> PurchaseScheduledInstancesAsync(PurchaseScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootInstances



        /// <summary>
        /// Requests a reboot of the specified instances. This operation is asynchronous; it only
        /// queues a request to reboot the specified instances. The operation succeeds if the
        /// instances are valid and belong to you. Requests to reboot terminated instances are
        /// ignored.
        /// 
        ///  
        /// <para>
        /// If an instance does not cleanly shut down within a few minutes, Amazon EC2 performs
        /// a hard reboot.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html">Troubleshoot
        /// an unreachable instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterImage



        /// <summary>
        /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
        /// before you can launch an instance from the AMI. For more information about creating
        /// AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
        /// your own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
        /// in a single request, so you don't have to register the AMI yourself.
        /// </para>
        ///  </note> 
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        ///  
        /// <para>
        ///  <b>Register a snapshot of a root device volume</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI from
        /// a snapshot of a root device volume. You specify the snapshot using a block device
        /// mapping. You can't set the encryption state of the volume using the block device mapping.
        /// If the snapshot is encrypted, or encryption by default is enabled, the root volume
        /// of an instance launched from the AMI is encrypted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
        /// a Linux AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Use
        /// encryption with Amazon EBS-backed AMIs</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon Web Services Marketplace product codes</b> 
        /// </para>
        ///  
        /// <para>
        /// If any snapshots have Amazon Web Services Marketplace product codes, they are copied
        /// to the new AMI.
        /// </para>
        ///  
        /// <para>
        /// Windows and some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and
        /// SUSE Linux Enterprise Server (SLES), use the Amazon EC2 billing product code associated
        /// with an AMI to verify the subscription status for package updates. To create a new
        /// AMI for operating systems that require a billing product code, instead of registering
        /// the AMI, do the following to preserve the billing product code association:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Launch an instance from an existing AMI with that billing product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customize the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create an AMI from the instance using <a>CreateImage</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you purchase a Reserved Instance to apply to an On-Demand Instance that was launched
        /// from an AMI with a billing product code, make sure that the Reserved Instance has
        /// the matching billing product code. If you purchase a Reserved Instance without the
        /// matching billing product code, the Reserved Instance will not be applied to the On-Demand
        /// Instance. For information about how to obtain the platform details and billing information
        /// of an AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understanding
        /// AMI billing</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterInstanceEventNotificationAttributes



        /// <summary>
        /// Registers a set of tag keys to include in scheduled event notifications for your resources.
        /// 
        /// 
        ///  
        /// <para>
        /// To remove tags, use .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstanceEventNotificationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterInstanceEventNotificationAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterInstanceEventNotificationAttributes">REST API Reference for RegisterInstanceEventNotificationAttributes Operation</seealso>
        Task<RegisterInstanceEventNotificationAttributesResponse> RegisterInstanceEventNotificationAttributesAsync(RegisterInstanceEventNotificationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterTransitGatewayMulticastGroupMembers



        /// <summary>
        /// Registers members (network interfaces) with the transit gateway multicast group. A
        /// member is a network interface associated with a supported EC2 instance that receives
        /// multicast traffic. For information about supported instances, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/transit-gateway-limits.html#multicast-limits">Multicast
        /// Consideration</a> in <i>Amazon VPC Transit Gateways</i>.
        /// 
        ///  
        /// <para>
        /// After you add the members, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SearchTransitGatewayMulticastGroups.html">SearchTransitGatewayMulticastGroups</a>
        /// to verify that the members were added to the transit gateway multicast group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGatewayMulticastGroupMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTransitGatewayMulticastGroupMembers service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterTransitGatewayMulticastGroupMembers">REST API Reference for RegisterTransitGatewayMulticastGroupMembers Operation</seealso>
        Task<RegisterTransitGatewayMulticastGroupMembersResponse> RegisterTransitGatewayMulticastGroupMembersAsync(RegisterTransitGatewayMulticastGroupMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterTransitGatewayMulticastGroupSources



        /// <summary>
        /// Registers sources (network interfaces) with the specified transit gateway multicast
        /// group.
        /// 
        ///  
        /// <para>
        /// A multicast source is a network interface attached to a supported instance that sends
        /// multicast traffic. For information about supported instances, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/transit-gateway-limits.html#multicast-limits">Multicast
        /// Considerations</a> in <i>Amazon VPC Transit Gateways</i>.
        /// </para>
        ///  
        /// <para>
        /// After you add the source, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SearchTransitGatewayMulticastGroups.html">SearchTransitGatewayMulticastGroups</a>
        /// to verify that the source was added to the multicast group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGatewayMulticastGroupSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTransitGatewayMulticastGroupSources service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterTransitGatewayMulticastGroupSources">REST API Reference for RegisterTransitGatewayMulticastGroupSources Operation</seealso>
        Task<RegisterTransitGatewayMulticastGroupSourcesResponse> RegisterTransitGatewayMulticastGroupSourcesAsync(RegisterTransitGatewayMulticastGroupSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectTransitGatewayMulticastDomainAssociations



        /// <summary>
        /// Rejects a request to associate cross-account subnets with a transit gateway multicast
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTransitGatewayMulticastDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectTransitGatewayMulticastDomainAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectTransitGatewayMulticastDomainAssociations">REST API Reference for RejectTransitGatewayMulticastDomainAssociations Operation</seealso>
        Task<RejectTransitGatewayMulticastDomainAssociationsResponse> RejectTransitGatewayMulticastDomainAssociationsAsync(RejectTransitGatewayMulticastDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectTransitGatewayPeeringAttachment



        /// <summary>
        /// Rejects a transit gateway peering attachment request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTransitGatewayPeeringAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectTransitGatewayPeeringAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectTransitGatewayPeeringAttachment">REST API Reference for RejectTransitGatewayPeeringAttachment Operation</seealso>
        Task<RejectTransitGatewayPeeringAttachmentResponse> RejectTransitGatewayPeeringAttachmentAsync(RejectTransitGatewayPeeringAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectTransitGatewayVpcAttachment



        /// <summary>
        /// Rejects a request to attach a VPC to a transit gateway.
        /// 
        ///  
        /// <para>
        /// The VPC attachment must be in the <code>pendingAcceptance</code> state. Use <a>DescribeTransitGatewayVpcAttachments</a>
        /// to view your pending VPC attachment requests. Use <a>AcceptTransitGatewayVpcAttachment</a>
        /// to accept a VPC attachment request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectTransitGatewayVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectTransitGatewayVpcAttachment service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectTransitGatewayVpcAttachment">REST API Reference for RejectTransitGatewayVpcAttachment Operation</seealso>
        Task<RejectTransitGatewayVpcAttachmentResponse> RejectTransitGatewayVpcAttachmentAsync(RejectTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectVpcEndpointConnections



        /// <summary>
        /// Rejects one or more VPC endpoint connection requests to your VPC endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        Task<RejectVpcEndpointConnectionsResponse> RejectVpcEndpointConnectionsAsync(RejectVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectVpcPeeringConnection



        /// <summary>
        /// Rejects a VPC peering connection request. The VPC peering connection must be in the
        /// <code>pending-acceptance</code> state. Use the <a>DescribeVpcPeeringConnections</a>
        /// request to view your outstanding VPC peering connection requests. To delete an active
        /// VPC peering connection, or to delete a VPC peering connection request that you initiated,
        /// use <a>DeleteVpcPeeringConnection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleaseAddress



        /// <summary>
        /// Releases the specified Elastic IP address.
        /// 
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
        /// it from any instance that it's associated with. To disassociate an Elastic IP address
        /// without releasing it, use <a>DisassociateAddress</a>.
        /// </para>
        ///  
        /// <para>
        /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you can release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        ///  
        /// <para>
        /// After releasing an Elastic IP address, it is released to the IP address pool. Be sure
        /// to update your DNS records and any servers or devices that communicate with the address.
        /// If you attempt to release an Elastic IP address that you already released, you'll
        /// get an <code>AuthFailure</code> error if the address is already allocated to another
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] After you release an Elastic IP address for use in a VPC, you might be able
        /// to recover it. For more information, see <a>AllocateAddress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleaseHosts



        /// <summary>
        /// When you no longer want to use an On-Demand Dedicated Host it can be released. On-Demand
        /// billing is stopped and the host goes into <code>released</code> state. The host ID
        /// of Dedicated Hosts that have been released can no longer be specified in another request,
        /// for example, to modify the host. You must stop or terminate all instances on a host
        /// before it can be released.
        /// 
        ///  
        /// <para>
        /// When Dedicated Hosts are released, it may take some time for them to stop counting
        /// toward your limit and you may receive capacity errors when trying to allocate new
        /// Dedicated Hosts. Wait a few minutes and then try again.
        /// </para>
        ///  
        /// <para>
        /// Released hosts still appear in a <a>DescribeHosts</a> response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        Task<ReleaseHostsResponse> ReleaseHostsAsync(ReleaseHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReleaseIpamPoolAllocation



        /// <summary>
        /// Release an allocation within an IPAM pool. You can only use this action to release
        /// manual allocations. To remove an allocation for a resource without deleting the resource,
        /// set its monitored state to false using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyIpamResourceCidr.html">ModifyIpamResourceCidr</a>.
        /// For more information, see <a href="/vpc/latest/ipam/release-pool-alloc-ipam.html">Release
        /// an allocation</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseIpamPoolAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseIpamPoolAllocation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseIpamPoolAllocation">REST API Reference for ReleaseIpamPoolAllocation Operation</seealso>
        Task<ReleaseIpamPoolAllocationResponse> ReleaseIpamPoolAllocationAsync(ReleaseIpamPoolAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceIamInstanceProfileAssociation



        /// <summary>
        /// Replaces an IAM instance profile for the specified running instance. You can use this
        /// action to change the IAM instance profile that's associated with an instance without
        /// having to disassociate the existing IAM instance profile first.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceIamInstanceProfileAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        Task<ReplaceIamInstanceProfileAssociationResponse> ReplaceIamInstanceProfileAssociationAsync(ReplaceIamInstanceProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceNetworkAclAssociation



        /// <summary>
        /// Changes which network ACL a subnet is associated with. By default when you create
        /// a subnet, it's automatically associated with the default network ACL. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This is an idempotent operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceNetworkAclEntry



        /// <summary>
        /// Replaces an entry (rule) in a network ACL. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceRoute



        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: internet gateway, virtual private gateway, NAT instance, NAT gateway,
        /// VPC peering connection, network interface, egress-only internet gateway, or transit
        /// gateway.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceRouteTableAssociation



        /// <summary>
        /// Changes the route table associated with a given subnet, internet gateway, or virtual
        /// private gateway in a VPC. After the operation completes, the subnet or gateway uses
        /// the routes in the new route table. For more information about route tables, see <a
        /// href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
        /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use this operation to change which table is the main route table in the
        /// VPC. Specify the main route table's association ID and the route table ID of the new
        /// main route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplaceTransitGatewayRoute



        /// <summary>
        /// Replaces the specified route in the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTransitGatewayRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplaceTransitGatewayRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceTransitGatewayRoute">REST API Reference for ReplaceTransitGatewayRoute Operation</seealso>
        Task<ReplaceTransitGatewayRouteResponse> ReplaceTransitGatewayRouteAsync(ReplaceTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReportInstanceStatus



        /// <summary>
        /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
        /// state. If your experience with the instance differs from the instance status returned
        /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
        /// with the instance. Amazon EC2 collects this information to improve the accuracy of
        /// status checks.
        /// 
        ///  
        /// <para>
        /// Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReportInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestSpotFleet



        /// <summary>
        /// Creates a Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// The Spot Fleet request specifies the total target capacity and the On-Demand target
        /// capacity. Amazon EC2 calculates the difference between the total capacity and On-Demand
        /// capacity, and launches the difference as Spot capacity.
        /// </para>
        ///  
        /// <para>
        /// You can submit a single request that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// By default, the Spot Fleet requests Spot Instances in the Spot Instance pool where
        /// the price per unit is the lowest. Each launch specification can include its own instance
        /// weighting that reflects the value of the instance type to your application workload.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify that the Spot Fleet distribute the target capacity
        /// across the Spot pools included in its launch specifications. By ensuring that the
        /// Spot Instances in your Spot Fleet are in different Spot pools, you can improve the
        /// availability of your fleet.
        /// </para>
        ///  
        /// <para>
        /// You can specify tags for the Spot Fleet request and instances launched by the fleet.
        /// You cannot tag other resource types in a Spot Fleet request because only the <code>spot-fleet-request</code>
        /// and <code>instance</code> resource types are supported.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html">Spot
        /// Fleet requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSpotFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestSpotInstances



        /// <summary>
        /// Creates a Spot Instance request.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetAddressAttribute



        /// <summary>
        /// Resets the attribute of the specified IP address. For requirements, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html#Using_Elastic_Addressing_Reverse_DNS">Using
        /// reverse DNS for email applications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAddressAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetAddressAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetAddressAttribute">REST API Reference for ResetAddressAttribute Operation</seealso>
        Task<ResetAddressAttributeResponse> ResetAddressAttributeAsync(ResetAddressAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetEbsDefaultKmsKeyId



        /// <summary>
        /// Resets the default KMS key for EBS encryption for your account in this Region to the
        /// Amazon Web Services managed KMS key for EBS.
        /// 
        ///  
        /// <para>
        /// After resetting the default KMS key to the Amazon Web Services managed KMS key, you
        /// can continue to encrypt by a customer managed KMS key by specifying it when you create
        /// the volume. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEbsDefaultKmsKeyId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetEbsDefaultKmsKeyId service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetEbsDefaultKmsKeyId">REST API Reference for ResetEbsDefaultKmsKeyId Operation</seealso>
        Task<ResetEbsDefaultKmsKeyIdResponse> ResetEbsDefaultKmsKeyIdAsync(ResetEbsDefaultKmsKeyIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetFpgaImageAttribute



        /// <summary>
        /// Resets the specified attribute of the specified Amazon FPGA Image (AFI) to its default
        /// value. You can only reset the load permission attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        Task<ResetFpgaImageAttributeResponse> ResetFpgaImageAttributeAsync(ResetFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetImageAttribute



        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetInstanceAttribute



        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
        /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>sourceDestCheck</code>,
        /// the instance can be either running or stopped.
        /// 
        ///  
        /// <para>
        /// The <code>sourceDestCheck</code> attribute controls whether source/destination checking
        /// is enabled. The default value is <code>true</code>, which means checking is enabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
        /// Instances</a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetNetworkInterfaceAttribute



        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetSnapshotAttribute



        /// <summary>
        /// Resets permission settings for the specified snapshot.
        /// 
        ///  
        /// <para>
        /// For more information about modifying snapshot permissions, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Share
        /// a snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreAddressToClassic



        /// <summary>
        /// Restores an Elastic IP address that was previously moved to the EC2-VPC platform back
        /// to the EC2-Classic platform. You cannot move an Elastic IP address that was originally
        /// allocated for use in EC2-VPC. The Elastic IP address must not be associated with an
        /// instance or network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreAddressToClassic service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreManagedPrefixListVersion



        /// <summary>
        /// Restores the entries from a previous version of a managed prefix list to a new version
        /// of the prefix list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreManagedPrefixListVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreManagedPrefixListVersion service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreManagedPrefixListVersion">REST API Reference for RestoreManagedPrefixListVersion Operation</seealso>
        Task<RestoreManagedPrefixListVersionResponse> RestoreManagedPrefixListVersionAsync(RestoreManagedPrefixListVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreSnapshotFromRecycleBin



        /// <summary>
        /// Restores a snapshot from the Recycle Bin. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-snaps.html#recycle-bin-restore-snaps">Restore
        /// snapshots from the Recycle Bin</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreSnapshotFromRecycleBin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreSnapshotFromRecycleBin service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreSnapshotFromRecycleBin">REST API Reference for RestoreSnapshotFromRecycleBin Operation</seealso>
        Task<RestoreSnapshotFromRecycleBinResponse> RestoreSnapshotFromRecycleBinAsync(RestoreSnapshotFromRecycleBinRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreSnapshotTier



        /// <summary>
        /// Restores an archived Amazon EBS snapshot for use temporarily or permanently, or modifies
        /// the restore period or restore type for a snapshot that was previously temporarily
        /// restored.
        /// 
        ///  
        /// <para>
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/working-with-snapshot-archiving.html#restore-archived-snapshot">
        /// Restore an archived snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/working-with-snapshot-archiving.html#modify-temp-restore-period">
        /// modify the restore period or restore type for a temporarily restored snapshot</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreSnapshotTier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreSnapshotTier service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreSnapshotTier">REST API Reference for RestoreSnapshotTier Operation</seealso>
        Task<RestoreSnapshotTierResponse> RestoreSnapshotTierAsync(RestoreSnapshotTierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeClientVpnIngress



        /// <summary>
        /// Removes an ingress authorization rule from a Client VPN endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClientVpnIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeClientVpnIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeClientVpnIngress">REST API Reference for RevokeClientVpnIngress Operation</seealso>
        Task<RevokeClientVpnIngressResponse> RevokeClientVpnIngressAsync(RevokeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSecurityGroupEgress



        /// <summary>
        /// [VPC only] Removes the specified outbound (egress) rules from a security group for
        /// EC2-VPC. This action does not apply to security groups for use in EC2-Classic.
        /// 
        ///  
        /// <para>
        /// You can specify rules using either rule IDs or security group rule properties. If
        /// you use rule properties, the values that you specify (for example, ports) must match
        /// the existing rule's values exactly. Each rule has a protocol, from and to ports, and
        /// destination (CIDR range, security group, or prefix list). For the TCP and UDP protocols,
        /// you must also specify the destination port or range of ports. For the ICMP protocol,
        /// you must also specify the ICMP type and code. If the security group rule has a description,
        /// you do not need to specify the description to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// [Default VPC] If the values you specify do not match the existing rule's values, no
        /// error is returned, and the output describes the security group rules that were not
        /// revoked.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services recommends that you describe the security group to verify that
        /// the rules were removed.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSecurityGroupIngress



        /// <summary>
        /// Removes the specified inbound (ingress) rules from a security group.
        /// 
        ///  
        /// <para>
        /// You can specify rules using either rule IDs or security group rule properties. If
        /// you use rule properties, the values that you specify (for example, ports) must match
        /// the existing rule's values exactly. Each rule has a protocol, from and to ports, and
        /// source (CIDR range, security group, or prefix list). For the TCP and UDP protocols,
        /// you must also specify the destination port or range of ports. For the ICMP protocol,
        /// you must also specify the ICMP type and code. If the security group rule has a description,
        /// you do not need to specify the description to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] If the values you specify do not match the existing rule's
        /// values, no error is returned, and the output describes the security group rules that
        /// were not revoked.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services recommends that you describe the security group to verify that
        /// the rules were removed.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RunInstances



        /// <summary>
        /// Launches the specified number of instances using an AMI for which you have permissions.
        /// 
        ///  
        /// <para>
        /// You can specify a number of options, or leave the default options. The following rules
        /// apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// [EC2-VPC] If you don't specify a subnet ID, we choose a default subnet from your default
        /// VPC for you. If you don't have a default VPC, you must specify a subnet ID in the
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-Classic] If don't specify an Availability Zone, we choose one for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some instance types must be launched into a VPC. If you do not have a default VPC,
        /// or if you do not specify a subnet ID, the request fails. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
        /// types available only in a VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-VPC] All instances have a network interface with a primary private IPv4 address.
        /// If you don't specify this address, we choose one from the IPv4 range of your subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not all instance types support IPv6 addresses. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify a security group ID, we use the default security group. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// groups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// the request fails.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a>, which is a resource that contains the parameters to launch an instance.
        /// When you launch an instance using <a>RunInstances</a>, you can specify the launch
        /// template instead of specifying the launch parameters.
        /// </para>
        ///  
        /// <para>
        /// To ensure faster instance launches, break up large requests into smaller batches.
        /// For example, create five separate launch requests for 100 instances each instead of
        /// one launch request for 500 instances.
        /// </para>
        ///  
        /// <para>
        /// An instance is ready for you to use when it's in the <code>running</code> state. You
        /// can check the state of your instance using <a>DescribeInstances</a>. You can tag instances
        /// and EBS volumes during launch, after launch, or both. For more information, see <a>CreateTags</a>
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// your Amazon EC2 resources</a>.
        /// </para>
        ///  
        /// <para>
        /// Linux instances have access to the public key of the key pair at boot. You can use
        /// this key to provide secure access to the instance. Amazon EC2 public images use this
        /// feature to provide secure access without passwords. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// pairs</a>.
        /// </para>
        ///  
        /// <para>
        /// For troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// to do if an instance immediately terminates</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// connecting to your instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RunScheduledInstances



        /// <summary>
        /// Launches the specified Scheduled Instances.
        /// 
        ///  
        /// <para>
        /// Before you can launch a Scheduled Instance, you must purchase it and obtain an identifier
        /// using <a>PurchaseScheduledInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// You must launch a Scheduled Instance during its scheduled time period. You can't stop
        /// or reboot a Scheduled Instance, but you can terminate it as needed. If you terminate
        /// a Scheduled Instance before the current scheduled time period ends, you can launch
        /// it again after a few minutes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html">Scheduled
        /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        Task<RunScheduledInstancesResponse> RunScheduledInstancesAsync(RunScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchLocalGatewayRoutes



        /// <summary>
        /// Searches for routes in the specified local gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchLocalGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchLocalGatewayRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SearchLocalGatewayRoutes">REST API Reference for SearchLocalGatewayRoutes Operation</seealso>
        Task<SearchLocalGatewayRoutesResponse> SearchLocalGatewayRoutesAsync(SearchLocalGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTransitGatewayMulticastGroups



        /// <summary>
        /// Searches one or more transit gateway multicast groups and returns the group membership
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTransitGatewayMulticastGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTransitGatewayMulticastGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SearchTransitGatewayMulticastGroups">REST API Reference for SearchTransitGatewayMulticastGroups Operation</seealso>
        Task<SearchTransitGatewayMulticastGroupsResponse> SearchTransitGatewayMulticastGroupsAsync(SearchTransitGatewayMulticastGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTransitGatewayRoutes



        /// <summary>
        /// Searches for routes in the specified transit gateway route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTransitGatewayRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTransitGatewayRoutes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SearchTransitGatewayRoutes">REST API Reference for SearchTransitGatewayRoutes Operation</seealso>
        Task<SearchTransitGatewayRoutesResponse> SearchTransitGatewayRoutesAsync(SearchTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendDiagnosticInterrupt



        /// <summary>
        /// Sends a diagnostic interrupt to the specified Amazon EC2 instance to trigger a <i>kernel
        /// panic</i> (on Linux instances), or a <i>blue screen</i>/<i>stop error</i> (on Windows
        /// instances). For instances based on Intel and AMD processors, the interrupt is received
        /// as a <i>non-maskable interrupt</i> (NMI).
        /// 
        ///  
        /// <para>
        /// In general, the operating system crashes and reboots when a kernel panic or stop error
        /// is triggered. The operating system can also be configured to perform diagnostic tasks,
        /// such as generating a memory dump file, loading a secondary kernel, or obtaining a
        /// call trace.
        /// </para>
        ///  
        /// <para>
        /// Before sending a diagnostic interrupt to your instance, ensure that its operating
        /// system is configured to perform the required diagnostic tasks.
        /// </para>
        ///  
        /// <para>
        /// For more information about configuring your operating system to generate a crash dump
        /// when a kernel panic or stop error occurs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/diagnostic-interrupt.html">Send
        /// a diagnostic interrupt (for advanced users)</a> (Linux instances) or <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/diagnostic-interrupt.html">Send
        /// a diagnostic interrupt (for advanced users)</a> (Windows instances).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDiagnosticInterrupt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDiagnosticInterrupt service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SendDiagnosticInterrupt">REST API Reference for SendDiagnosticInterrupt Operation</seealso>
        Task<SendDiagnosticInterruptResponse> SendDiagnosticInterruptAsync(SendDiagnosticInterruptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInstances



        /// <summary>
        /// Starts an Amazon EBS-backed instance that you've previously stopped.
        /// 
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for instance usage. However, your root partition Amazon EBS volume
        /// remains and continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. Every time you start your instance,
        /// Amazon EC2 charges a one-minute minimum for instance usage, and thereafter charges
        /// per second for instance usage.
        /// </para>
        ///  
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to start a T3 instance with <code>host</code> tenancy and the <code>unlimted</code>
        /// CPU credit option, the request fails. The <code>unlimited</code> CPU credit option
        /// is not supported on Dedicated Hosts. Before you start the instance, either change
        /// its CPU credit option to <code>standard</code>, or change its tenancy to <code>default</code>
        /// or <code>dedicated</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stop
        /// and start your instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartNetworkInsightsAccessScopeAnalysis



        /// <summary>
        /// Starts analyzing the specified Network Access Scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkInsightsAccessScopeAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNetworkInsightsAccessScopeAnalysis service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartNetworkInsightsAccessScopeAnalysis">REST API Reference for StartNetworkInsightsAccessScopeAnalysis Operation</seealso>
        Task<StartNetworkInsightsAccessScopeAnalysisResponse> StartNetworkInsightsAccessScopeAnalysisAsync(StartNetworkInsightsAccessScopeAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartNetworkInsightsAnalysis



        /// <summary>
        /// Starts analyzing the specified path. If the path is reachable, the operation returns
        /// the shortest feasible path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkInsightsAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNetworkInsightsAnalysis service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartNetworkInsightsAnalysis">REST API Reference for StartNetworkInsightsAnalysis Operation</seealso>
        Task<StartNetworkInsightsAnalysisResponse> StartNetworkInsightsAnalysisAsync(StartNetworkInsightsAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartVpcEndpointServicePrivateDnsVerification



        /// <summary>
        /// Initiates the verification process to prove that the service provider owns the private
        /// DNS name domain for the endpoint service.
        /// 
        ///  
        /// <para>
        /// The service provider must successfully perform the verification before the consumer
        /// can use the name to access the service.
        /// </para>
        ///  
        /// <para>
        /// Before the service provider runs this command, they must add a record to the DNS server.
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-services-dns-validation.html#add-dns-txt-record">Adding
        /// a TXT Record to Your Domain's DNS Server </a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVpcEndpointServicePrivateDnsVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartVpcEndpointServicePrivateDnsVerification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartVpcEndpointServicePrivateDnsVerification">REST API Reference for StartVpcEndpointServicePrivateDnsVerification Operation</seealso>
        Task<StartVpcEndpointServicePrivateDnsVerificationResponse> StartVpcEndpointServicePrivateDnsVerificationAsync(StartVpcEndpointServicePrivateDnsVerificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInstances



        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// 
        ///  
        /// <para>
        /// You can use the Stop action to hibernate an instance if the instance is <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html#enabling-hibernation">enabled
        /// for hibernation</a> and it meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html#hibernating-prerequisites">hibernation
        /// prerequisites</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// We don't charge usage for a stopped instance, or data transfer fees; however, your
        /// root partition Amazon EBS volume remains and continues to persist your data, and you
        /// are charged for Amazon EBS volume usage. Every time you start your instance, Amazon
        /// EC2 charges a one-minute minimum for instance usage, and thereafter charges per second
        /// for instance usage.
        /// </para>
        ///  
        /// <para>
        /// You can't stop or hibernate instance store-backed instances. You can't use the Stop
        /// action to hibernate Spot Instances, but you can specify that Amazon EC2 should hibernate
        /// Spot Instances when they are interrupted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-interruptions.html#hibernate-spot-instances">Hibernating
        /// interrupted Spot Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop or hibernate an instance, we shut it down. You can restart your instance
        /// at any time. Before stopping or hibernating an instance, make sure it is in a state
        /// from which it can be restarted. Stopping an instance does not preserve data stored
        /// in RAM, but hibernating an instance does preserve data stored in RAM. If an instance
        /// cannot hibernate successfully, a normal shutdown occurs.
        /// </para>
        ///  
        /// <para>
        /// Stopping and hibernating an instance is different to rebooting or terminating it.
        /// For example, when you stop or hibernate an instance, the root device and any other
        /// devices attached to the instance persist. When you terminate an instance, the root
        /// device and any other devices attached during the instance launch are automatically
        /// deleted. For more information about the differences between rebooting, stopping, hibernating,
        /// and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we attempt to shut it down forcibly after a short while.
        /// If your instance appears stuck in the stopping state after a period of time, there
        /// may be an issue with the underlying host computer. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshoot
        /// stopping your instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateClientVpnConnections



        /// <summary>
        /// Terminates active Client VPN endpoint connections. This action can be used to terminate
        /// a specific client connection, or up to five connections established by a specific
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateClientVpnConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateClientVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateClientVpnConnections">REST API Reference for TerminateClientVpnConnections Operation</seealso>
        Task<TerminateClientVpnConnectionsResponse> TerminateClientVpnConnectionsAsync(TerminateClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateInstances



        /// <summary>
        /// Shuts down the specified instances. This operation is idempotent; if you terminate
        /// an instance more than once, each call succeeds. 
        /// 
        ///  
        /// <para>
        /// If you specify multiple instances and the request fails (for example, because of a
        /// single incorrect instance ID), none of the instances are terminated.
        /// </para>
        ///  
        /// <para>
        /// If you terminate multiple instances across multiple Availability Zones, and one or
        /// more of the specified instances are enabled for termination protection, the request
        /// fails with the following results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The specified instances that are in the same Availability Zone as the protected instance
        /// are not terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified instances that are in different Availability Zones, where no other specified
        /// instances are protected, are successfully terminated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, say you have the following instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instance A: <code>us-east-1a</code>; Not protected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance B: <code>us-east-1a</code>; Not protected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance C: <code>us-east-1b</code>; Protected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance D: <code>us-east-1b</code>; not protected
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you attempt to terminate all of these instances in the same request, the request
        /// reports failure with the following results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instance A and Instance B are successfully terminated because none of the specified
        /// instances in <code>us-east-1a</code> are enabled for termination protection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance C and Instance D fail to terminate because at least one of the specified
        /// instances in <code>us-east-1b</code> (Instance C) is enabled for termination protection.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Terminated instances remain visible after termination (for approximately one hour).
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 deletes all EBS volumes that were attached when the instance
        /// launched. Volumes attached after instance launch continue running.
        /// </para>
        ///  
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
        /// store-backed instances. What happens to an instance differs if you stop it or terminate
        /// it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, any attached EBS
        /// volumes with the <code>DeleteOnTermination</code> block device mapping parameter set
        /// to <code>true</code> are automatically deleted. For more information about the differences
        /// between stopping and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
        /// terminating your instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignIpv6Addresses



        /// <summary>
        /// Unassigns one or more IPv6 addresses IPv4 Prefix Delegation prefixes from a network
        /// interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnassignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesAsync(UnassignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignPrivateIpAddresses



        /// <summary>
        /// Unassigns one or more secondary private IP addresses, or IPv4 Prefix Delegation prefixes
        /// from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnmonitorInstances



        /// <summary>
        /// Disables detailed monitoring for a running instance. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// your instances and volumes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityGroupRuleDescriptionsEgress



        /// <summary>
        /// [VPC only] Updates the description of an egress (outbound) security group rule. You
        /// can replace an existing description, or add a description to a rule that did not have
        /// one previously. You can remove a description for a security group rule by omitting
        /// the description parameter in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        Task<UpdateSecurityGroupRuleDescriptionsEgressResponse> UpdateSecurityGroupRuleDescriptionsEgressAsync(UpdateSecurityGroupRuleDescriptionsEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityGroupRuleDescriptionsIngress



        /// <summary>
        /// Updates the description of an ingress (inbound) security group rule. You can replace
        /// an existing description, or add a description to a rule that did not have one previously.
        /// You can remove a description for a security group rule by omitting the description
        /// parameter in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        Task<UpdateSecurityGroupRuleDescriptionsIngressResponse> UpdateSecurityGroupRuleDescriptionsIngressAsync(UpdateSecurityGroupRuleDescriptionsIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  WithdrawByoipCidr



        /// <summary>
        /// Stops advertising an address range that is provisioned as an address pool.
        /// 
        ///  
        /// <para>
        /// You can perform this operation at most once every 10 seconds, even if you specify
        /// different address ranges each time.
        /// </para>
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses stops routing
        /// to Amazon Web Services because of BGP propagation delays.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the WithdrawByoipCidr service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        Task<WithdrawByoipCidrResponse> WithdrawByoipCidrAsync(WithdrawByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}