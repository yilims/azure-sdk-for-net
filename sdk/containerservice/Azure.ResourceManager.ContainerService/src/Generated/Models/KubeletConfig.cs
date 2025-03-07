// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details. </summary>
    public partial class KubeletConfig
    {
        /// <summary> Initializes a new instance of <see cref="KubeletConfig"/>. </summary>
        public KubeletConfig()
        {
            AllowedUnsafeSysctls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubeletConfig"/>. </summary>
        /// <param name="cpuManagerPolicy"> The default is 'none'. See [Kubernetes CPU management policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more information. Allowed values are 'none' and 'static'. </param>
        /// <param name="isCpuCfsQuotaEnabled"> The default is true. </param>
        /// <param name="cpuCfsQuotaPeriod"> The default is '100ms.' Valid values are a sequence of decimal numbers with an optional fraction and a unit suffix. For example: '300ms', '2h45m'. Supported units are 'ns', 'us', 'ms', 's', 'm', and 'h'. </param>
        /// <param name="imageGcHighThreshold"> To disable image garbage collection, set to 100. The default is 85%. </param>
        /// <param name="imageGcLowThreshold"> This cannot be set higher than imageGcHighThreshold. The default is 80%. </param>
        /// <param name="topologyManagerPolicy"> For more information see [Kubernetes Topology Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is 'none'. Allowed values are 'none', 'best-effort', 'restricted', and 'single-numa-node'. </param>
        /// <param name="allowedUnsafeSysctls"> Allowed list of unsafe sysctls or unsafe sysctl patterns (ending in `*`). </param>
        /// <param name="failStartWithSwapOn"> If set to true it will make the Kubelet fail to start if swap is enabled on the node. </param>
        /// <param name="containerLogMaxSizeInMB"> The maximum size (e.g. 10Mi) of container log file before it is rotated. </param>
        /// <param name="containerLogMaxFiles"> The maximum number of container log files that can be present for a container. The number must be ≥ 2. </param>
        /// <param name="podMaxPids"> The maximum number of processes per pod. </param>
        internal KubeletConfig(string cpuManagerPolicy, bool? isCpuCfsQuotaEnabled, string cpuCfsQuotaPeriod, int? imageGcHighThreshold, int? imageGcLowThreshold, string topologyManagerPolicy, IList<string> allowedUnsafeSysctls, bool? failStartWithSwapOn, int? containerLogMaxSizeInMB, int? containerLogMaxFiles, int? podMaxPids)
        {
            CpuManagerPolicy = cpuManagerPolicy;
            IsCpuCfsQuotaEnabled = isCpuCfsQuotaEnabled;
            CpuCfsQuotaPeriod = cpuCfsQuotaPeriod;
            ImageGcHighThreshold = imageGcHighThreshold;
            ImageGcLowThreshold = imageGcLowThreshold;
            TopologyManagerPolicy = topologyManagerPolicy;
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            FailStartWithSwapOn = failStartWithSwapOn;
            ContainerLogMaxSizeInMB = containerLogMaxSizeInMB;
            ContainerLogMaxFiles = containerLogMaxFiles;
            PodMaxPids = podMaxPids;
        }

        /// <summary> The default is 'none'. See [Kubernetes CPU management policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more information. Allowed values are 'none' and 'static'. </summary>
        public string CpuManagerPolicy { get; set; }
        /// <summary> The default is true. </summary>
        public bool? IsCpuCfsQuotaEnabled { get; set; }
        /// <summary> The default is '100ms.' Valid values are a sequence of decimal numbers with an optional fraction and a unit suffix. For example: '300ms', '2h45m'. Supported units are 'ns', 'us', 'ms', 's', 'm', and 'h'. </summary>
        public string CpuCfsQuotaPeriod { get; set; }
        /// <summary> To disable image garbage collection, set to 100. The default is 85%. </summary>
        public int? ImageGcHighThreshold { get; set; }
        /// <summary> This cannot be set higher than imageGcHighThreshold. The default is 80%. </summary>
        public int? ImageGcLowThreshold { get; set; }
        /// <summary> For more information see [Kubernetes Topology Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is 'none'. Allowed values are 'none', 'best-effort', 'restricted', and 'single-numa-node'. </summary>
        public string TopologyManagerPolicy { get; set; }
        /// <summary> Allowed list of unsafe sysctls or unsafe sysctl patterns (ending in `*`). </summary>
        public IList<string> AllowedUnsafeSysctls { get; }
        /// <summary> If set to true it will make the Kubelet fail to start if swap is enabled on the node. </summary>
        public bool? FailStartWithSwapOn { get; set; }
        /// <summary> The maximum size (e.g. 10Mi) of container log file before it is rotated. </summary>
        public int? ContainerLogMaxSizeInMB { get; set; }
        /// <summary> The maximum number of container log files that can be present for a container. The number must be ≥ 2. </summary>
        public int? ContainerLogMaxFiles { get; set; }
        /// <summary> The maximum number of processes per pod. </summary>
        public int? PodMaxPids { get; set; }
    }
}
