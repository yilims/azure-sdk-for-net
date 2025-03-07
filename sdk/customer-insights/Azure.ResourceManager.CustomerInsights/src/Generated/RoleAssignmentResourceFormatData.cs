// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the RoleAssignmentResourceFormat data model.
    /// The Role Assignment resource format.
    /// </summary>
    public partial class RoleAssignmentResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RoleAssignmentResourceFormatData"/>. </summary>
        public RoleAssignmentResourceFormatData()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
            Principals = new ChangeTrackingList<AssignmentPrincipal>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentResourceFormatData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="assignmentName"> The name of the metadata object. </param>
        /// <param name="displayName"> Localized display names for the metadata. </param>
        /// <param name="description"> Localized description for the metadata. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="role"> Type of roles. </param>
        /// <param name="principals"> The principals being assigned to. </param>
        /// <param name="profiles"> Profiles set for the assignment. </param>
        /// <param name="interactions"> Interactions set for the assignment. </param>
        /// <param name="links"> Links set for the assignment. </param>
        /// <param name="kpis"> Kpis set for the assignment. </param>
        /// <param name="sasPolicies"> Sas Policies set for the assignment. </param>
        /// <param name="connectors"> Connectors set for the assignment. </param>
        /// <param name="views"> Views set for the assignment. </param>
        /// <param name="relationshipLinks"> The Role assignments set for the relationship links. </param>
        /// <param name="relationships"> The Role assignments set for the relationships. </param>
        /// <param name="widgetTypes"> Widget types set for the assignment. </param>
        /// <param name="roleAssignments"> The Role assignments set for the assignment. </param>
        /// <param name="conflationPolicies"> Widget types set for the assignment. </param>
        /// <param name="segments"> The Role assignments set for the assignment. </param>
        internal RoleAssignmentResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? tenantId, string assignmentName, IDictionary<string, string> displayName, IDictionary<string, string> description, ProvisioningState? provisioningState, RoleType? role, IList<AssignmentPrincipal> principals, ResourceSetDescription profiles, ResourceSetDescription interactions, ResourceSetDescription links, ResourceSetDescription kpis, ResourceSetDescription sasPolicies, ResourceSetDescription connectors, ResourceSetDescription views, ResourceSetDescription relationshipLinks, ResourceSetDescription relationships, ResourceSetDescription widgetTypes, ResourceSetDescription roleAssignments, ResourceSetDescription conflationPolicies, ResourceSetDescription segments) : base(id, name, resourceType, systemData)
        {
            TenantId = tenantId;
            AssignmentName = assignmentName;
            DisplayName = displayName;
            Description = description;
            ProvisioningState = provisioningState;
            Role = role;
            Principals = principals;
            Profiles = profiles;
            Interactions = interactions;
            Links = links;
            Kpis = kpis;
            SasPolicies = sasPolicies;
            Connectors = connectors;
            Views = views;
            RelationshipLinks = relationshipLinks;
            Relationships = relationships;
            WidgetTypes = widgetTypes;
            RoleAssignments = roleAssignments;
            ConflationPolicies = conflationPolicies;
            Segments = segments;
        }

        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The name of the metadata object. </summary>
        public string AssignmentName { get; }
        /// <summary> Localized display names for the metadata. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Localized description for the metadata. </summary>
        public IDictionary<string, string> Description { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Type of roles. </summary>
        public RoleType? Role { get; set; }
        /// <summary> The principals being assigned to. </summary>
        public IList<AssignmentPrincipal> Principals { get; }
        /// <summary> Profiles set for the assignment. </summary>
        public ResourceSetDescription Profiles { get; set; }
        /// <summary> Interactions set for the assignment. </summary>
        public ResourceSetDescription Interactions { get; set; }
        /// <summary> Links set for the assignment. </summary>
        public ResourceSetDescription Links { get; set; }
        /// <summary> Kpis set for the assignment. </summary>
        public ResourceSetDescription Kpis { get; set; }
        /// <summary> Sas Policies set for the assignment. </summary>
        public ResourceSetDescription SasPolicies { get; set; }
        /// <summary> Connectors set for the assignment. </summary>
        public ResourceSetDescription Connectors { get; set; }
        /// <summary> Views set for the assignment. </summary>
        public ResourceSetDescription Views { get; set; }
        /// <summary> The Role assignments set for the relationship links. </summary>
        public ResourceSetDescription RelationshipLinks { get; set; }
        /// <summary> The Role assignments set for the relationships. </summary>
        public ResourceSetDescription Relationships { get; set; }
        /// <summary> Widget types set for the assignment. </summary>
        public ResourceSetDescription WidgetTypes { get; set; }
        /// <summary> The Role assignments set for the assignment. </summary>
        public ResourceSetDescription RoleAssignments { get; set; }
        /// <summary> Widget types set for the assignment. </summary>
        public ResourceSetDescription ConflationPolicies { get; set; }
        /// <summary> The Role assignments set for the assignment. </summary>
        public ResourceSetDescription Segments { get; set; }
    }
}
