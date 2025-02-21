// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting seasonality.
    /// Please note <see cref="ForecastingSeasonality"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutoSeasonality"/> and <see cref="CustomSeasonality"/>.
    /// </summary>
    public abstract partial class ForecastingSeasonality
    {
        /// <summary> Initializes a new instance of <see cref="ForecastingSeasonality"/>. </summary>
        protected ForecastingSeasonality()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ForecastingSeasonality"/>. </summary>
        /// <param name="mode"> [Required] Seasonality mode. </param>
        internal ForecastingSeasonality(SeasonalityMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] Seasonality mode. </summary>
        internal SeasonalityMode Mode { get; set; }
    }
}
