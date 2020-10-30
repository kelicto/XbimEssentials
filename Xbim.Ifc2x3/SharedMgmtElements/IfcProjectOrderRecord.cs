// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.SharedMgmtElements;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IfcProjectOrderRecord", 697)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectOrderRecord : IfcControl, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcProjectOrderRecord>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectOrderRecord(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_records = new ItemSet<IfcRelAssignsToProjectOrder>( this, 0,  6);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcRelAssignsToProjectOrder> _records;
		private IfcProjectOrderRecordTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 12)]
		public IItemSet<IfcRelAssignsToProjectOrder> @Records 
		{ 
			get 
			{
				if(_activated) return _records;
				Activate();
				return _records;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 13)]
		public IfcProjectOrderRecordTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_records.InternalAdd((IfcRelAssignsToProjectOrder)value.EntityVal);
					return;
				case 6: 
                    _predefinedType = (IfcProjectOrderRecordTypeEnum) System.Enum.Parse(typeof (IfcProjectOrderRecordTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProjectOrderRecord other)
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
				foreach(var entity in @Records)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}