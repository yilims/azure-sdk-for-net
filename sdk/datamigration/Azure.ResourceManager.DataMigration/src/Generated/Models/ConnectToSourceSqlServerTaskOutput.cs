// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary>
    /// Output for the task that validates connection to SQL Server and also validates source server requirements
    /// Please note <see cref="ConnectToSourceSqlServerTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConnectToSourceSqlServerTaskOutputAgentJobLevel"/>, <see cref="ConnectToSourceSqlServerTaskOutputDatabaseLevel"/>, <see cref="ConnectToSourceSqlServerTaskOutputLoginLevel"/> and <see cref="ConnectToSourceSqlServerTaskOutputTaskLevel"/>.
    /// </summary>
    public abstract partial class ConnectToSourceSqlServerTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutput"/>. </summary>
        protected ConnectToSourceSqlServerTaskOutput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Type of result - database level or task level. </param>
        internal ConnectToSourceSqlServerTaskOutput(string id, string resultType)
        {
            Id = id;
            ResultType = resultType;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Type of result - database level or task level. </summary>
        internal string ResultType { get; set; }
    }
}
