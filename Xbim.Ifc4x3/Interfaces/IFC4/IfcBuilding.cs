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
	public partial class @IfcBuilding : IIfcBuilding
	{

		[CrossSchemaAttribute(typeof(IIfcBuilding), 10)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcBuilding.ElevationOfRefHeight 
		{ 
			get
			{
				if (!ElevationOfRefHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(ElevationOfRefHeight.Value);
			} 
			set
			{
				ElevationOfRefHeight = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBuilding), 11)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcBuilding.ElevationOfTerrain 
		{ 
			get
			{
				if (!ElevationOfTerrain.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(ElevationOfTerrain.Value);
			} 
			set
			{
				ElevationOfTerrain = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBuilding), 12)]
		IIfcPostalAddress IIfcBuilding.BuildingAddress 
		{ 
			get
			{
				return BuildingAddress;
			} 
			set
			{
				BuildingAddress = value as ActorResource.IfcPostalAddress;
				
			}
		}
	//## Custom code

		/// <summary>
		/// Returns the site (if any) that contains this building, null if the building is not decomposing a site
		/// </summary>
		/// <returns></returns>
		public IIfcSite Site
		{
			get
			{
				return Decomposes.SelectMany(r => r.RelatedObjects).OfType<IIfcSite>().FirstOrDefault();
			}
		}

		/// <summary>
		/// Returns the buidlings that decompose this building
		/// </summary>
		/// <returns></returns>
		public IEnumerable<IIfcBuilding> Buildings
		{
			get
			{
				return IsDecomposedBy.SelectMany(s => s.RelatedObjects).OfType<IIfcBuilding>();
			}
		}

		/// <summary>
		/// Returns all spaces that are sub-spaces of this building
		/// </summary>
		/// <returns></returns>
		public IEnumerable<IIfcSpace> Spaces
		{
			get
			{
				return IsDecomposedBy.SelectMany(s => s.RelatedObjects).OfType<IIfcSpace>();
			}
		}



		/// <summary>
		/// Returns the building storeys for this floor  
		/// </summary>
		/// <returns></returns>
		public IEnumerable<IIfcBuildingStorey> BuildingStoreys
		{
			get
			{
				return IsDecomposedBy.SelectMany(s => s.RelatedObjects).OfType<IIfcBuildingStorey>()
					.OrderBy(s => s.Elevation.HasValue ? s.Elevation.Value : 0f);
			}
		}
		//##
	}
}