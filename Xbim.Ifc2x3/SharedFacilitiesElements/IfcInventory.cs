// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.SharedFacilitiesElements;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IfcInventory", 768)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcInventory>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_responsiblePersons = new ItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum _inventoryType;
		private IfcActorSelect _jurisdiction;
		private readonly ItemSet<IfcPerson> _responsiblePersons;
		private IfcCalendarDate _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 12)]
		public IfcInventoryTypeEnum @InventoryType 
		{ 
			get 
			{
				if(_activated) return _inventoryType;
				Activate();
				return _inventoryType;
			} 
			set
			{
				SetValue( v =>  _inventoryType = v, _inventoryType, value,  "InventoryType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 13)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(_activated) return _jurisdiction;
				Activate();
				return _jurisdiction;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 14)]
		public IItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(_activated) return _responsiblePersons;
				Activate();
				return _responsiblePersons;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 15)]
		public IfcCalendarDate @LastUpdateDate 
		{ 
			get 
			{
				if(_activated) return _lastUpdateDate;
				Activate();
				return _lastUpdateDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 16)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(_activated) return _currentValue;
				Activate();
				return _currentValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 17)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(_activated) return _originalValue;
				Activate();
				return _originalValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue", 11);
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
                    _inventoryType = (IfcInventoryTypeEnum) System.Enum.Parse(typeof (IfcInventoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_jurisdiction = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					_responsiblePersons.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_lastUpdateDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 9: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 10: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcInventory other)
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
				if (@Jurisdiction != null)
					yield return @Jurisdiction;
				foreach(var entity in @ResponsiblePersons)
					yield return entity;
				if (@LastUpdateDate != null)
					yield return @LastUpdateDate;
				if (@CurrentValue != null)
					yield return @CurrentValue;
				if (@OriginalValue != null)
					yield return @OriginalValue;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}