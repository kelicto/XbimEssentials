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
namespace Xbim.Ifc4x3.GeometricModelResource
{
	public partial class @IfcSweptDiskSolidPolygonal : IIfcSweptDiskSolidPolygonal
	{

		[CrossSchemaAttribute(typeof(IIfcSweptDiskSolidPolygonal), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcSweptDiskSolidPolygonal.FilletRadius 
		{ 
			get
			{
				if (!FilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FilletRadius.Value);
			} 
			set
			{
				FilletRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}