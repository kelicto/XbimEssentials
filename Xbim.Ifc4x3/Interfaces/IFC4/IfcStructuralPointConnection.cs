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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralPointConnection : IIfcStructuralPointConnection
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralPointConnection), 9)]
		IIfcAxis2Placement3D IIfcStructuralPointConnection.ConditionCoordinateSystem 
		{ 
			get
			{
				return ConditionCoordinateSystem;
			} 
			set
			{
				ConditionCoordinateSystem = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}
	//## Custom code
	//##
	}
}