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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcRelSpaceBoundary1stLevel : IIfcRelSpaceBoundary1stLevel
	{

		[CrossSchemaAttribute(typeof(IIfcRelSpaceBoundary1stLevel), 10)]
		IIfcRelSpaceBoundary1stLevel IIfcRelSpaceBoundary1stLevel.ParentBoundary 
		{ 
			get
			{
				return ParentBoundary;
			} 
			set
			{
				ParentBoundary = value as IfcRelSpaceBoundary1stLevel;
				
			}
		}
		IEnumerable<IIfcRelSpaceBoundary1stLevel> IIfcRelSpaceBoundary1stLevel.InnerBoundaries 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSpaceBoundary1stLevel>(e => (e.ParentBoundary as IfcRelSpaceBoundary1stLevel) == this, "ParentBoundary", this);
			} 
		}
	//## Custom code
	//##
	}
}