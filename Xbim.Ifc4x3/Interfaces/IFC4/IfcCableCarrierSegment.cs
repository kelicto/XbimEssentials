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
namespace Xbim.Ifc4x3.ElectricalDomain
{
	public partial class @IfcCableCarrierSegment : IIfcCableCarrierSegment
	{

		[CrossSchemaAttribute(typeof(IIfcCableCarrierSegment), 9)]
		Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum? IIfcCableCarrierSegment.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT:
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT;
					case IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT:
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT;
					case IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT:
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT;
					case IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT:
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT;
					case IfcCableCarrierSegmentTypeEnum.CABLEBRACKET:
						//## Handle translation of CABLEBRACKET member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of CABLEBRACKET member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableCarrierSegmentTypeEnum.CATENARYWIRE:
						//## Handle translation of CATENARYWIRE member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of CATENARYWIRE member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableCarrierSegmentTypeEnum.DROPPER:
						//## Handle translation of DROPPER member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						//TODO: Handle translation of DROPPER member from IfcCableCarrierSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcCableCarrierSegmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.USERDEFINED;
					case IfcCableCarrierSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT;
						return;
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.USERDEFINED:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCableCarrierSegmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcCableCarrierSegmentTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}