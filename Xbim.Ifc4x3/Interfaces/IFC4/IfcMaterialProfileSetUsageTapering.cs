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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialProfileSetUsageTapering : IIfcMaterialProfileSetUsageTapering
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialProfileSetUsageTapering), 4)]
		IIfcMaterialProfileSet IIfcMaterialProfileSetUsageTapering.ForProfileEndSet 
		{ 
			get
			{
				return ForProfileEndSet;
			} 
			set
			{
				ForProfileEndSet = value as IfcMaterialProfileSet;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialProfileSetUsageTapering), 5)]
		Ifc4.MaterialResource.IfcCardinalPointReference? IIfcMaterialProfileSetUsageTapering.CardinalEndPoint 
		{ 
			get
			{
				if (!CardinalEndPoint.HasValue) return null;
				return new Ifc4.MaterialResource.IfcCardinalPointReference(CardinalEndPoint.Value);
			} 
			set
			{
				CardinalEndPoint = value.HasValue ? 
					new IfcCardinalPointReference(value.Value) :  
					 new IfcCardinalPointReference?() ;
				
			}
		}
	//## Custom code
	//##
	}
}