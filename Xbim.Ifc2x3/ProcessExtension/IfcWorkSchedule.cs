// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ProcessExtension;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcWorkSchedule", 186)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkSchedule : IfcWorkControl, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcWorkSchedule>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkSchedule(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}





		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
				case 12: 
				case 13: 
				case 14: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkSchedule other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@CreationDate != null)
					yield return @CreationDate;
				foreach(var entity in @Creators)
					yield return entity;
				if (@StartTime != null)
					yield return @StartTime;
				if (@FinishTime != null)
					yield return @FinishTime;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}