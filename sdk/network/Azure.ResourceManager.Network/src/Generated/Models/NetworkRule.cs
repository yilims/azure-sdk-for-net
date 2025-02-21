// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rule of type network. </summary>
    public partial class NetworkRule : FirewallPolicyRule
    {
        /// <summary> Initializes a new instance of <see cref="NetworkRule"/>. </summary>
        public NetworkRule()
        {
            IPProtocols = new ChangeTrackingList<FirewallPolicyRuleNetworkProtocol>();
            SourceAddresses = new ChangeTrackingList<string>();
            DestinationAddresses = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
            SourceIPGroups = new ChangeTrackingList<string>();
            DestinationIPGroups = new ChangeTrackingList<string>();
            DestinationFqdns = new ChangeTrackingList<string>();
            RuleType = FirewallPolicyRuleType.NetworkRule;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRule"/>. </summary>
        /// <param name="name"> Name of the rule. </param>
        /// <param name="description"> Description of the rule. </param>
        /// <param name="ruleType"> Rule Type. </param>
        /// <param name="ipProtocols"> Array of FirewallPolicyRuleNetworkProtocols. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or Service Tags. </param>
        /// <param name="destinationPorts"> List of destination ports. </param>
        /// <param name="sourceIPGroups"> List of source IpGroups for this rule. </param>
        /// <param name="destinationIPGroups"> List of destination IpGroups for this rule. </param>
        /// <param name="destinationFqdns"> List of destination FQDNs. </param>
        internal NetworkRule(string name, string description, FirewallPolicyRuleType ruleType, IList<FirewallPolicyRuleNetworkProtocol> ipProtocols, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<string> destinationPorts, IList<string> sourceIPGroups, IList<string> destinationIPGroups, IList<string> destinationFqdns) : base(name, description, ruleType)
        {
            IPProtocols = ipProtocols;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            SourceIPGroups = sourceIPGroups;
            DestinationIPGroups = destinationIPGroups;
            DestinationFqdns = destinationFqdns;
            RuleType = ruleType;
        }

        /// <summary> Array of FirewallPolicyRuleNetworkProtocols. </summary>
        public IList<FirewallPolicyRuleNetworkProtocol> IPProtocols { get; }
        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; }
        /// <summary> List of destination IP addresses or Service Tags. </summary>
        public IList<string> DestinationAddresses { get; }
        /// <summary> List of destination ports. </summary>
        public IList<string> DestinationPorts { get; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIPGroups { get; }
        /// <summary> List of destination IpGroups for this rule. </summary>
        public IList<string> DestinationIPGroups { get; }
        /// <summary> List of destination FQDNs. </summary>
        public IList<string> DestinationFqdns { get; }
    }
}
