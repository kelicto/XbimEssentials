// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.GeometryResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometryResource
{
	[ExpressType("IfcBSplineSurface", 1102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBSplineSurface : IfcBoundedSurface, IEquatable<@IfcBSplineSurface>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_controlPointsList = new ItemSet<IItemSet<IfcCartesianPoint>>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcInteger _uDegree;
		private IfcInteger _vDegree;
		private readonly ItemSet<IItemSet<IfcCartesianPoint>> _controlPointsList;
		private IfcBSplineSurfaceForm _surfaceForm;
		private IfcLogical _uClosed;
		private IfcLogical _vClosed;
		private IfcLogical _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcInteger @UDegree 
		{ 
			get 
			{
				if(_activated) return _uDegree;
				Activate();
				return _uDegree;
			} 
			set
			{
				SetValue( v =>  _uDegree = v, _uDegree, value,  "UDegree", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcInteger @VDegree 
		{ 
			get 
			{
				if(_activated) return _vDegree;
				Activate();
				return _vDegree;
			} 
			set
			{
				SetValue( v =>  _vDegree = v, _vDegree, value,  "VDegree", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, new int [] { 2, 2 }, new int [] { -1, -1 }, 5)]
		public IItemSet<IItemSet<IfcCartesianPoint>> @ControlPointsList 
		{ 
			get 
			{
				if(_activated) return _controlPointsList;
				Activate();
				return _controlPointsList;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 6)]
		public IfcBSplineSurfaceForm @SurfaceForm 
		{ 
			get 
			{
				if(_activated) return _surfaceForm;
				Activate();
				return _surfaceForm;
			} 
			set
			{
				SetValue( v =>  _surfaceForm = v, _surfaceForm, value,  "SurfaceForm", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLogical @UClosed 
		{ 
			get 
			{
				if(_activated) return _uClosed;
				Activate();
				return _uClosed;
			} 
			set
			{
				SetValue( v =>  _uClosed = v, _uClosed, value,  "UClosed", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLogical @VClosed 
		{ 
			get 
			{
				if(_activated) return _vClosed;
				Activate();
				return _vClosed;
			} 
			set
			{
				SetValue( v =>  _vClosed = v, _vClosed, value,  "VClosed", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcLogical @SelfIntersect 
		{ 
			get 
			{
				if(_activated) return _selfIntersect;
				Activate();
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect", 7);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @UUpper 
		{
			get 
			{
				//## Getter for UUpper
			    return ControlPointsList.Count - 1;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcInteger @VUpper 
		{
			get 
			{
				//## Getter for VUpper
                return ControlPointsList[1].Count - 1;
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.Array, new int [] { 0, 0 }, new int [] { -1, -1 }, 0)]
		public List<List<Common.Geometry.XbimPoint3D>> @ControlPoints 
		{
			get 
			{
				//## Getter for ControlPoints
			    var result = new List<List<Common.Geometry.XbimPoint3D>>();
			    foreach (var list in ControlPointsList)
			    {
			        var inner = new List<Common.Geometry.XbimPoint3D>();
                    result.Add(inner);
			        inner.AddRange(list.Select(point => new Common.Geometry.XbimPoint3D(point.X, point.Y, point.Z)));
			    }
			    return result;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_uDegree = value.IntegerVal;
					return;
				case 1: 
					_vDegree = value.IntegerVal;
					return;
				case 2: 
					((ItemSet<IfcCartesianPoint>)_controlPointsList
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcCartesianPoint)(value.EntityVal));
					return;
				case 3: 
                    _surfaceForm = (IfcBSplineSurfaceForm) System.Enum.Parse(typeof (IfcBSplineSurfaceForm), value.EnumVal, true);
					return;
				case 4: 
					_uClosed = value.BooleanVal;
					return;
				case 5: 
					_vClosed = value.BooleanVal;
					return;
				case 6: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBSplineSurface other)
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