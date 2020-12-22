// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using Xbim.Ifc4x3.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationDefinitionResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationDefinitionResource
{
	[ExpressType("IfcTextLiteral", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteral : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcTextLiteral>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteral(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPresentableText _literal;
		private IfcAxis2Placement _placement;
		private IfcTextPath _path;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcPresentableText @Literal 
		{ 
			get 
			{
				if(_activated) return _literal;
				Activate();
				return _literal;
			} 
			set
			{
				SetValue( v =>  _literal = v, _literal, value,  "Literal", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcAxis2Placement @Placement 
		{ 
			get 
			{
				if(_activated) return _placement;
				Activate();
				return _placement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _placement = v, _placement, value,  "Placement", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 5)]
		public IfcTextPath @Path 
		{ 
			get 
			{
				if(_activated) return _path;
				Activate();
				return _path;
			} 
			set
			{
				SetValue( v =>  _path = v, _path, value,  "Path", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_literal = value.StringVal;
					return;
				case 1: 
					_placement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 2: 
                    _path = (IfcTextPath) System.Enum.Parse(typeof (IfcTextPath), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextLiteral other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Placement != null)
					yield return @Placement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}