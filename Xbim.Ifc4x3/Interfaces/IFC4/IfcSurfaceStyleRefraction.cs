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
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcSurfaceStyleRefraction : IIfcSurfaceStyleRefraction
	{

		[CrossSchemaAttribute(typeof(IIfcSurfaceStyleRefraction), 1)]
		Ifc4.MeasureResource.IfcReal? IIfcSurfaceStyleRefraction.RefractionIndex 
		{ 
			get
			{
				if (!RefractionIndex.HasValue) return null;
				return new Ifc4.MeasureResource.IfcReal(RefractionIndex.Value);
			} 
			set
			{
				RefractionIndex = value.HasValue ? 
					new MeasureResource.IfcReal(value.Value) :  
					 new MeasureResource.IfcReal?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSurfaceStyleRefraction), 2)]
		Ifc4.MeasureResource.IfcReal? IIfcSurfaceStyleRefraction.DispersionFactor 
		{ 
			get
			{
				if (!DispersionFactor.HasValue) return null;
				return new Ifc4.MeasureResource.IfcReal(DispersionFactor.Value);
			} 
			set
			{
				DispersionFactor = value.HasValue ? 
					new MeasureResource.IfcReal(value.Value) :  
					 new MeasureResource.IfcReal?() ;
				
			}
		}
	//## Custom code
	//##
	}
}