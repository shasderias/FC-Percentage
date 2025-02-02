﻿using UnityEngine;

namespace FCPercentage.Configuration
{
	class ResultsAdvancedSettings
	{
		// Advanced settings available from config file
		public virtual string ScorePrefixText { get; set; } = "FC : ";
		public virtual string PercentagePrefixText { get; set; } = "FC : ";
		public virtual string PercentageTotalPrefixText { get; set; } = "";
		public virtual string PercentageSplitSaberAPrefixText { get; set; } = "";
		public virtual string PercentageSplitSaberBPrefixText { get; set; } = "";
		public virtual string DifferencePositiveColor { get; set; } = "#00B300";
		public virtual string DifferenceNegativeColor { get; set; } = "#FF0000";
	}
}
