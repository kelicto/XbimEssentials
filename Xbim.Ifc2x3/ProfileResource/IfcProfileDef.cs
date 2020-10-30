// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcProfileDef", 105)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProfileDef : PersistEntity, IEquatable<@IfcProfileDef>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcProfileTypeEnum _profileType;
		private IfcLabel? _profileName;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 1)]
		public IfcProfileTypeEnum @ProfileType 
		{ 
			get 
			{
				if(_activated) return _profileType;
				Activate();
				return _profileType;
			} 
			set
			{
				SetValue( v =>  _profileType = v, _profileType, value,  "ProfileType", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @ProfileName 
		{ 
			get 
			{
				if(_activated) return _profileName;
				Activate();
				return _profileName;
			} 
			set
			{
				SetValue( v =>  _profileName = v, _profileName, value,  "ProfileName", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _profileType = (IfcProfileTypeEnum) System.Enum.Parse(typeof (IfcProfileTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_profileName = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}