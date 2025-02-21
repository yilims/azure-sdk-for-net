// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a load balancing rule. </summary>
    public partial class ManagedClusterLoadBalancingRule
    {
        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancingRule"/>. </summary>
        /// <param name="frontendPort"> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534. </param>
        /// <param name="backendPort"> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the load balancing rule. </param>
        /// <param name="probeProtocol"> the reference to the load balancer probe used by the load balancing rule. </param>
        public ManagedClusterLoadBalancingRule(int frontendPort, int backendPort, ManagedClusterLoadBalancingRuleTransportProtocol protocol, ManagedClusterLoadBalanceProbeProtocol probeProtocol)
        {
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            Protocol = protocol;
            ProbeProtocol = probeProtocol;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancingRule"/>. </summary>
        /// <param name="frontendPort"> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534. </param>
        /// <param name="backendPort"> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the load balancing rule. </param>
        /// <param name="probePort"> The prob port used by the load balancing rule. Acceptable values are between 1 and 65535. </param>
        /// <param name="probeProtocol"> the reference to the load balancer probe used by the load balancing rule. </param>
        /// <param name="probeRequestPath"> The probe request path. Only supported for HTTP/HTTPS probes. </param>
        /// <param name="loadDistribution"> The load distribution policy for this rule. </param>
        internal ManagedClusterLoadBalancingRule(int frontendPort, int backendPort, ManagedClusterLoadBalancingRuleTransportProtocol protocol, int? probePort, ManagedClusterLoadBalanceProbeProtocol probeProtocol, string probeRequestPath, string loadDistribution)
        {
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            Protocol = protocol;
            ProbePort = probePort;
            ProbeProtocol = probeProtocol;
            ProbeRequestPath = probeRequestPath;
            LoadDistribution = loadDistribution;
        }

        /// <summary> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534. </summary>
        public int FrontendPort { get; set; }
        /// <summary> The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. </summary>
        public int BackendPort { get; set; }
        /// <summary> The reference to the transport protocol used by the load balancing rule. </summary>
        public ManagedClusterLoadBalancingRuleTransportProtocol Protocol { get; set; }
        /// <summary> The prob port used by the load balancing rule. Acceptable values are between 1 and 65535. </summary>
        public int? ProbePort { get; set; }
        /// <summary> the reference to the load balancer probe used by the load balancing rule. </summary>
        public ManagedClusterLoadBalanceProbeProtocol ProbeProtocol { get; set; }
        /// <summary> The probe request path. Only supported for HTTP/HTTPS probes. </summary>
        public string ProbeRequestPath { get; set; }
        /// <summary> The load distribution policy for this rule. </summary>
        public string LoadDistribution { get; set; }
    }
}
