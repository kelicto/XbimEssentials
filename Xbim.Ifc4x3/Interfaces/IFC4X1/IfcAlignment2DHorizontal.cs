// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	public partial class @IfcAlignment2DHorizontal : IIfcAlignment2DHorizontal
	{

		[CrossSchemaAttribute(typeof(IIfcAlignment2DHorizontal), 1)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcAlignment2DHorizontal.StartDistAlong 
		{ 
			get
			{
				if (!StartDistAlong.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(StartDistAlong.Value);
			} 
			set
			{
				StartDistAlong = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAlignment2DHorizontal), 2)]
		IItemSet<IIfcAlignment2DHorizontalSegment> IIfcAlignment2DHorizontal.Segments 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcAlignment2DHorizontalSegment, IIfcAlignment2DHorizontalSegment>(Segments);
			} 
		}
		IEnumerable<IIfcAlignmentCurve> IIfcAlignment2DHorizontal.ToAlignmentCurve 
		{ 
			get
			{
				return Model.Instances.Where<IIfcAlignmentCurve>(e => (e.Horizontal as IfcAlignment2DHorizontal) == this, "Horizontal", this);
			} 
		}
	//## Custom code
	//##
	}
}