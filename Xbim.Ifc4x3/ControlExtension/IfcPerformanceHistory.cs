// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ControlExtension;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ControlExtension
{
	[ExpressType("IfcPerformanceHistory", 710)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerformanceHistory : IfcControl, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcPerformanceHistory>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPerformanceHistory(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _lifeCyclePhase;
		private IfcPerformanceHistoryTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 19)]
		public IfcLabel @LifeCyclePhase 
		{ 
			get 
			{
				if(_activated) return _lifeCyclePhase;
				Activate();
				return _lifeCyclePhase;
			} 
			set
			{
				SetValue( v =>  _lifeCyclePhase = v, _lifeCyclePhase, value,  "LifeCyclePhase", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 20)]
		public IfcPerformanceHistoryTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 8);
			} 
		}	
		#endregion




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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_lifeCyclePhase = value.StringVal;
					return;
				case 7: 
                    _predefinedType = (IfcPerformanceHistoryTypeEnum) System.Enum.Parse(typeof (IfcPerformanceHistoryTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerformanceHistory other)
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
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}