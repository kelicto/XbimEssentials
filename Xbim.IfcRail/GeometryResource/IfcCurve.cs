// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.GeometricModelResource;
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
	[ExpressType("IfcCurve", 68)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCurve : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IEquatable<@IfcCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
                //## Getter for Dim
                var line = this as IfcLine;
                if (line != null)
                    return line.Pnt.Dim;
                var conic = this as IfcConic;
                if (conic != null)
                    return conic.Position.Dim;
                var polyline = this as IfcPolyline;
                if (polyline != null)
                    return polyline.Points[1].Dim;
                var trimmed = this as IfcTrimmedCurve;
                if (trimmed != null)
                    return trimmed.BasisCurve.Dim;
                var composit = this as IfcCompositeCurve;
                if (composit != null)
                    return composit.Segments[1].Dim;
                var bspline = this as IfcBSplineCurve;
                if (bspline != null)
                    return bspline.ControlPointsList[1].Dim;
                if (this is IfcOffsetCurve2D)
                    return 2;
                if (this is IfcOffsetCurve3D)
                    return 3;
                if (this is IfcOffsetCurveByDistances)
                    return 3;
                if (this is IfcCurveSegment2D)
                    return 2;
                if (this is GeometricConstraintResource.IfcAlignmentCurve)
                    return 3;
                if (this is IfcPcurve)
                    return 3;
                if (this is IfcIndexedPolyCurve ipc)
                    return ipc.Points.Dim;
                return new IfcDimensionCount(0);
                //##
            }
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurve other)
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