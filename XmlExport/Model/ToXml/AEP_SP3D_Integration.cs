using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace XmlExport.Model.ToXml
{
    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Objects", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtObjects
    {
        private CtSlab[] _cSpsSlabEntityField;

        private CtWall[] _sPsWallPartField;

        private CtMemberPartPrismatic[] _cSpsMemberPartPrismaticField;

        private CtMemberPartCurve[] _cSpsMemberPartCurveField;

        private CtCoordinateSystem[] _cSpgCoordinateSystemField;

        private CtHandrail[] _cSpsHandrailField;

        private CtStairLadder[] _cSpsLadderField;

        private CtStairLadder[] _cSpsStairField;

        private CtEquipment[] _cPSmartEquipmentField;

        private CtSpace[] _cPInterferenceVolumeField;

        private CtSpace[] _cAreaField;

        private CtSpace[] _cZoneField;

        private CtSpace[] _cDwgVolumeField;

        /// <remarks />
        [XmlElementAttribute("CSPSSlabEntity")]
        public CtSlab[] CspsSlabEntity
        {
            get => _cSpsSlabEntityField;
            set => _cSpsSlabEntityField = value;
        }

        /// <remarks />
        [XmlElementAttribute("SPSWallPart")]
        public CtWall[] SpsWallPart
        {
            get => _sPsWallPartField;
            set => _sPsWallPartField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPSMemberPartPrismatic")]
        public CtMemberPartPrismatic[] CspsMemberPartPrismatic
        {
            get => _cSpsMemberPartPrismaticField;
            set => _cSpsMemberPartPrismaticField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPSMemberPartCurve")]
        public CtMemberPartCurve[] CspsMemberPartCurve
        {
            get => _cSpsMemberPartCurveField;
            set => _cSpsMemberPartCurveField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPGCoordinateSystem")]
        public CtCoordinateSystem[] CspgCoordinateSystem
        {
            get => _cSpgCoordinateSystemField;
            set => _cSpgCoordinateSystemField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPSHandrail")]
        public CtHandrail[] CspsHandrail
        {
            get => _cSpsHandrailField;
            set => _cSpsHandrailField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPSLadder")]
        public CtStairLadder[] CspsLadder
        {
            get => _cSpsLadderField;
            set => _cSpsLadderField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSPSStair")]
        public CtStairLadder[] CspsStair
        {
            get => _cSpsStairField;
            set => _cSpsStairField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPSmartEquipment")]
        public CtEquipment[] CpSmartEquipment
        {
            get => _cPSmartEquipmentField;
            set => _cPSmartEquipmentField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPInterferenceVolume")]
        public CtSpace[] CpInterferenceVolume
        {
            get => _cPInterferenceVolumeField;
            set => _cPInterferenceVolumeField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CArea")]
        public CtSpace[] CArea
        {
            get => _cAreaField;
            set => _cAreaField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CZone")]
        public CtSpace[] CZone
        {
            get => _cZoneField;
            set => _cZoneField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CDwgVolume")]
        public CtSpace[] CDwgVolume
        {
            get => _cDwgVolumeField;
            set => _cDwgVolumeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPSSlabEntity", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtSlab : CtSlabOrWall
    {
        private CtContour _contourField;

        private CtPoint3d _normalField;

        private decimal _normalOffsetField;

        private bool _normalOffsetFieldSpecified;

        private decimal _thicknessField;

        private StFacePosition _facePositionField;

        private StSlabReferenceDirection _boundProjDirectionField;

        private bool _boundProjDirectionFieldSpecified;

        private StSlabReferenceDirection _thickeningDirectionField;

        private bool _thickeningDirectionFieldSpecified;

        private decimal _boundaryOffsetField;

        private bool _boundaryOffsetFieldSpecified;

        private StSlabBoundaryReference _boundaryOffsetRefField;

        private bool _boundaryOffsetRefFieldSpecified;

        /// <remarks />
        public CtContour Contour
        {
            get => _contourField;
            set => _contourField = value;
        }

        /// <remarks />
        public CtPoint3d Normal
        {
            get => _normalField;
            set => _normalField = value;
        }

        /// <remarks />
        public decimal NormalOffset
        {
            get => _normalOffsetField;
            set => _normalOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool NormalOffsetSpecified
        {
            get => _normalOffsetFieldSpecified;
            set => _normalOffsetFieldSpecified = value;
        }

        /// <remarks />
        public decimal Thickness
        {
            get => _thicknessField;
            set => _thicknessField = value;
        }

        /// <remarks />
        public StFacePosition FacePosition
        {
            get => _facePositionField;
            set => _facePositionField = value;
        }

        /// <remarks />
        public StSlabReferenceDirection BoundProjDirection
        {
            get => _boundProjDirectionField;
            set => _boundProjDirectionField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool BoundProjDirectionSpecified
        {
            get => _boundProjDirectionFieldSpecified;
            set => _boundProjDirectionFieldSpecified = value;
        }

        /// <remarks />
        public StSlabReferenceDirection ThickeningDirection
        {
            get => _thickeningDirectionField;
            set => _thickeningDirectionField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ThickeningDirectionSpecified
        {
            get => _thickeningDirectionFieldSpecified;
            set => _thickeningDirectionFieldSpecified = value;
        }

        /// <remarks />
        public decimal BoundaryOffset
        {
            get => _boundaryOffsetField;
            set => _boundaryOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool BoundaryOffsetSpecified
        {
            get => _boundaryOffsetFieldSpecified;
            set => _boundaryOffsetFieldSpecified = value;
        }

        /// <remarks />
        public StSlabBoundaryReference BoundaryOffsetRef
        {
            get => _boundaryOffsetRefField;
            set => _boundaryOffsetRefField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool BoundaryOffsetRefSpecified
        {
            get => _boundaryOffsetRefFieldSpecified;
            set => _boundaryOffsetRefFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Contour", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtContour
    {
        private object[] _itemsField;

        /// <remarks />
        [XmlElementAttribute("Arc3d", typeof(CtArc3d))]
        [XmlElementAttribute("BSplineCurve3d", typeof(CtBSplineCurve3d))]
        [XmlElementAttribute("Circle3d", typeof(CtCircle3d))]
        [XmlElementAttribute("Ellipse3d", typeof(CtEllipse3d))]
        [XmlElementAttribute("EllipticalArc3d", typeof(CtEllipticalArc3d))]
        [XmlElementAttribute("Line3d", typeof(CtCurveOpen))]
        public object[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Arc3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtArc3d : CtCurveOpen
    {
        private CtPoint3d _alongPointField;

        /// <remarks />
        public CtPoint3d AlongPoint
        {
            get => _alongPointField;
            set => _alongPointField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("StartPoint", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPoint3d
    {
        private decimal _xField;

        private decimal _yField;

        private decimal _zField;

        /// <remarks />
        [XmlAttributeAttribute]
        public decimal X
        {
            get => _xField;
            set => _xField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public decimal Y
        {
            get => _yField;
            set => _yField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public decimal Z
        {
            get => _zField;
            set => _zField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtMemberPartCurve))]
    [XmlIncludeAttribute(typeof(CtMemberPartPrismatic))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    public class CtMemberPart
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private string _memberTypeCategoryField;

        private string _memberTypeField;

        private CtMaterial _materialField;

        private CtCrossSection _crossSectionField;

        private CtOpening[] _openingsField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "positiveInteger")]
        public string MemberTypeCategory
        {
            get => _memberTypeCategoryField;
            set => _memberTypeCategoryField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "positiveInteger")]
        public string MemberType
        {
            get => _memberTypeField;
            set => _memberTypeField = value;
        }

        /// <remarks />
        public CtMaterial Material
        {
            get => _materialField;
            set => _materialField = value;
        }

        /// <remarks />
        public CtCrossSection CrossSection
        {
            get => _crossSectionField;
            set => _crossSectionField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Opening", IsNullable = false)]
        public CtOpening[] Openings
        {
            get => _openingsField;
            set => _openingsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("ID", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtId
    {
        private string _modelIdField;

        private string _valueField;

        /// <remarks />
        [XmlAttributeAttribute(DataType = "token")]
        public string ModelId
        {
            get => _modelIdField;
            set => _modelIdField = value;
        }

        /// <remarks />
        [XmlTextAttribute(DataType = "token")]
        public string Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("WBSItem", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtWbsItem
    {
        private string _projectNameField;

        private string _nameField;

        private string _purposeField;

        private string _typeField;

        /// <remarks />
        [XmlAttributeAttribute]
        public string ProjectName
        {
            get => _projectNameField;
            set => _projectNameField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute(DataType = "positiveInteger")]
        public string Purpose
        {
            get => _purposeField;
            set => _purposeField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute(DataType = "positiveInteger")]
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Parent", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtParent
    {
        private string _nameField;

        private StSystemType _systemTypeField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public StSystemType SystemType
        {
            get => _systemTypeField;
            set => _systemTypeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("SystemType", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StSystemType
    {
        CpAreaSystem,
        CpConduitSystem,
        CpDuctingSystem,
        CpElectricalSystem,
        CpHullOufittingSystem,
        CpMachinerySystem,
        CpmSystem,
        CpPipelineSystem,
        CpPipingSystem,
        CpStructuralSystem,
        CpUnitSystem
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Material", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtMaterial
    {
        private string _typeField;

        private string _gradeField;

        /// <remarks />
        [XmlAttributeAttribute]
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Grade
        {
            get => _gradeField;
            set => _gradeField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtStructureCrossSection))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CrossSection", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCrossSection
    {
        private string _cardinalPointField;

        private bool _reflectField;

        private bool _reflectFieldSpecified;

        private decimal _angleField;

        private bool _angleFieldSpecified;

        private string _referenceStandardField;

        private string _typeField;

        private string _nameField;

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string CardinalPoint
        {
            get => _cardinalPointField;
            set => _cardinalPointField = value;
        }

        /// <remarks />
        public bool Reflect
        {
            get => _reflectField;
            set => _reflectField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ReflectSpecified
        {
            get => _reflectFieldSpecified;
            set => _reflectFieldSpecified = value;
        }

        /// <remarks />
        public decimal Angle
        {
            get => _angleField;
            set => _angleField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool AngleSpecified
        {
            get => _angleFieldSpecified;
            set => _angleFieldSpecified = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string ReferenceStandard
        {
            get => _referenceStandardField;
            set => _referenceStandardField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Opening", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtOpening
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtContour _contourField;

        private decimal _cuttingDepthField;

        private CtPoint3d _directionField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        public CtContour Contour
        {
            get => _contourField;
            set => _contourField = value;
        }

        /// <remarks />
        public decimal CuttingDepth
        {
            get => _cuttingDepthField;
            set => _cuttingDepthField = value;
        }

        /// <remarks />
        public CtPoint3d Direction
        {
            get => _directionField;
            set => _directionField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtWall))]
    [XmlIncludeAttribute(typeof(CtSlab))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    public class CtSlabOrWall
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private string _coordinateSystemField;

        private CtPart _structureTypeField;

        private CtPart _structureCompositionField;

        private CtOpening[] _openingsField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public string CoordinateSystem
        {
            get => _coordinateSystemField;
            set => _coordinateSystemField = value;
        }

        /// <remarks />
        public CtPart StructureType
        {
            get => _structureTypeField;
            set => _structureTypeField = value;
        }

        /// <remarks />
        public CtPart StructureComposition
        {
            get => _structureCompositionField;
            set => _structureCompositionField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Opening", IsNullable = false)]
        public CtOpening[] Openings
        {
            get => _openingsField;
            set => _openingsField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtSection))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("StructureType", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPart
    {
        private string _partClassField;

        private string _partNumberField;

        /// <remarks />
        [XmlAttributeAttribute(DataType = "token")]
        public string PartClass
        {
            get => _partClassField;
            set => _partClassField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute(DataType = "token")]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtBSplineCurve3d))]
    [XmlIncludeAttribute(typeof(CtEllipticalArc3d))]
    [XmlIncludeAttribute(typeof(CtArc3d))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Line3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCurveOpen
    {
        private CtPoint3d _startPointField;

        private CtPoint3d _endPointField;

        /// <remarks />
        public CtPoint3d StartPoint
        {
            get => _startPointField;
            set => _startPointField = value;
        }

        /// <remarks />
        public CtPoint3d EndPoint
        {
            get => _endPointField;
            set => _endPointField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("BSplineCurve3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtBSplineCurve3d : CtCurveOpen
    {
        private string _orderField;

        private CtPole[] _polesField;

        private decimal[] _knotsField;

        /// <remarks />
        [XmlElementAttribute(DataType = "positiveInteger")]
        public string Order
        {
            get => _orderField;
            set => _orderField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Pole", IsNullable = false)]
        public CtPole[] Poles
        {
            get => _polesField;
            set => _polesField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Knot", IsNullable = false)]
        public decimal[] Knots
        {
            get => _knotsField;
            set => _knotsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Pole", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPole
    {
        private CtPoint3d _positionField;

        private decimal _weightField;

        private bool _weightFieldSpecified;

        /// <remarks />
        public CtPoint3d Position
        {
            get => _positionField;
            set => _positionField = value;
        }

        /// <remarks />
        public decimal Weight
        {
            get => _weightField;
            set => _weightField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool WeightSpecified
        {
            get => _weightFieldSpecified;
            set => _weightFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Circle3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCircle3d
    {
        private CtPoint3d _centerPointField;

        private decimal _radiusField;

        private CtPoint3d _normalField;

        /// <remarks />
        public CtPoint3d CenterPoint
        {
            get => _centerPointField;
            set => _centerPointField = value;
        }

        /// <remarks />
        public decimal Radius
        {
            get => _radiusField;
            set => _radiusField = value;
        }

        /// <remarks />
        public CtPoint3d Normal
        {
            get => _normalField;
            set => _normalField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Ellipse3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtEllipse3d
    {
        private CtPoint3d _centerPointField;

        private decimal _minorMajorRatioField;

        private CtPoint3d _normalField;

        private CtPoint3d _majorAxisField;

        /// <remarks />
        public CtPoint3d CenterPoint
        {
            get => _centerPointField;
            set => _centerPointField = value;
        }

        /// <remarks />
        public decimal MinorMajorRatio
        {
            get => _minorMajorRatioField;
            set => _minorMajorRatioField = value;
        }

        /// <remarks />
        public CtPoint3d Normal
        {
            get => _normalField;
            set => _normalField = value;
        }

        /// <remarks />
        public CtPoint3d MajorAxis
        {
            get => _majorAxisField;
            set => _majorAxisField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("EllipticalArc3d", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtEllipticalArc3d : CtCurveOpen
    {
        private CtPoint3d _centerPointField;

        private decimal _minorMajorRatioField;

        private CtPoint3d _normalField;

        private CtPoint3d _majorAxisField;

        /// <remarks />
        public CtPoint3d CenterPoint
        {
            get => _centerPointField;
            set => _centerPointField = value;
        }

        /// <remarks />
        public decimal MinorMajorRatio
        {
            get => _minorMajorRatioField;
            set => _minorMajorRatioField = value;
        }

        /// <remarks />
        public CtPoint3d Normal
        {
            get => _normalField;
            set => _normalField = value;
        }

        /// <remarks />
        public CtPoint3d MajorAxis
        {
            get => _majorAxisField;
            set => _majorAxisField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("FacePosition", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StFacePosition
    {
        /// <remarks />
        Top,

        /// <remarks />
        Bottom,

        /// <remarks />
        Center
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("BoundProjDirection", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StSlabReferenceDirection
    {
        /// <remarks />
        Normal,

        /// <remarks />
        Vertical,

        /// <remarks />
        Horizontal
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("BoundaryOffsetRef", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StSlabBoundaryReference
    {
        Inner,
        Center,
        Outer
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("SPSWallPart", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtWall : CtSlabOrWall
    {
        private CtStructureCrossSection _structureCrossSectionField;

        private CtPath _pathField;

        /// <remarks />
        public CtStructureCrossSection StructureCrossSection
        {
            get => _structureCrossSectionField;
            set => _structureCrossSectionField = value;
        }

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("StructureCrossSection", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtStructureCrossSection : CtCrossSection
    {
        private decimal _horisontalOffsetField;

        private bool _horisontalOffsetFieldSpecified;

        private decimal _verticalOffsetField;

        private bool _verticalOffsetFieldSpecified;

        private decimal _thicknessField;

        private decimal _heightField;

        /// <remarks />
        public decimal HorisontalOffset
        {
            get => _horisontalOffsetField;
            set => _horisontalOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool HorisontalOffsetSpecified
        {
            get => _horisontalOffsetFieldSpecified;
            set => _horisontalOffsetFieldSpecified = value;
        }

        /// <remarks />
        public decimal VerticalOffset
        {
            get => _verticalOffsetField;
            set => _verticalOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool VerticalOffsetSpecified
        {
            get => _verticalOffsetFieldSpecified;
            set => _verticalOffsetFieldSpecified = value;
        }

        /// <remarks />
        public decimal Thickness
        {
            get => _thicknessField;
            set => _thicknessField = value;
        }

        /// <remarks />
        public decimal Height
        {
            get => _heightField;
            set => _heightField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Path", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPath
    {
        private CtCurveOpen[] _itemsField;

        /// <remarks />
        [XmlElementAttribute("Arc3d", typeof(CtArc3d))]
        [XmlElementAttribute("BSplineCurve3d", typeof(CtBSplineCurve3d))]
        [XmlElementAttribute("EllipticalArc3d", typeof(CtEllipticalArc3d))]
        [XmlElementAttribute("Line3d", typeof(CtCurveOpen))]
        public CtCurveOpen[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPSMemberPartPrismatic", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtMemberPartPrismatic : CtMemberPart
    {
        private CtCurveOpen _pointsField;

        /// <remarks />
        public CtCurveOpen Points
        {
            get => _pointsField;
            set => _pointsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPSMemberPartCurve", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtMemberPartCurve : CtMemberPart
    {
        private CtPath _pathField;

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPGCoordinateSystem", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCoordinateSystem
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private CtPlane[] _planesZField;

        private CtPlanes[] _itemsField;

        private ItemsChoiceType[] _itemsElementNameField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Plane", IsNullable = false)]
        public CtPlane[] PlanesZ
        {
            get => _planesZField;
            set => _planesZField = value;
        }

        /// <remarks />
        [XmlElementAttribute("PlanesCylindrical", typeof(CtPlanes))]
        [XmlElementAttribute("PlanesRadial", typeof(CtPlanes))]
        [XmlElementAttribute("PlanesX", typeof(CtPlanes))]
        [XmlElementAttribute("PlanesY", typeof(CtPlanes))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public CtPlanes[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute]
        public ItemsChoiceType[] ItemsElementName
        {
            get => _itemsElementNameField;
            set => _itemsElementNameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Plane", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPlane
    {
        private string _nameField;

        private string _typeIdField;

        private decimal _offsetField;

        public CtPlane()
        {
            _typeIdField = "1";
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public string TypeId
        {
            get => _typeIdField;
            set => _typeIdField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public decimal Offset
        {
            get => _offsetField;
            set => _offsetField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("PlanesX", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPlanes
    {
        private CtPlane[] _planeField;

        /// <remarks />
        [XmlElementAttribute("Plane")]
        public CtPlane[] Plane
        {
            get => _planeField;
            set => _planeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        /// <remarks />
        PlanesCylindrical,

        /// <remarks />
        PlanesRadial,

        /// <remarks />
        PlanesX,

        /// <remarks />
        PlanesY
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPSHandrail", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtHandrail
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private CtPart _partField;

        private CtAttribute[] _attributesField;

        private CtPath _pathField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public CtPart Part
        {
            get => _partField;
            set => _partField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Attribute", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtAttribute
    {
        private string _relationNavigationPathField;

        private string _interfaceField;

        private string _attributeField;

        private string _valueField;

        /// <remarks />
        [XmlAttributeAttribute]
        public string RelationNavigationPath
        {
            get => _relationNavigationPathField;
            set => _relationNavigationPathField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Interface
        {
            get => _interfaceField;
            set => _interfaceField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Attribute
        {
            get => _attributeField;
            set => _attributeField = value;
        }

        /// <remarks />
        [XmlAttributeAttribute]
        public string Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSPSLadder", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtStairLadder
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private CtPart _partField;

        private CtAttribute[] _attributesField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private CtPoint3d _vectorZField;

        private CtPoint3d _basePointField;

        private CtPoint3d _normalField;

        private CtCurveOpen _topEdgeField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public CtPart Part
        {
            get => _partField;
            set => _partField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public CtPoint3d VectorZ
        {
            get => _vectorZField;
            set => _vectorZField = value;
        }

        /// <remarks />
        public CtPoint3d BasePoint
        {
            get => _basePointField;
            set => _basePointField = value;
        }

        /// <remarks />
        public CtPoint3d Normal
        {
            get => _normalField;
            set => _normalField = value;
        }

        /// <remarks />
        public CtCurveOpen TopEdge
        {
            get => _topEdgeField;
            set => _topEdgeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPSmartEquipment", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtEquipment
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtParent[] _parentsField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private CtEquipmentComponent[] _equipmentComponentsField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("CPEquipmentComponent", IsNullable = false)]
        public CtEquipmentComponent[] EquipmentComponents
        {
            get => _equipmentComponentsField;
            set => _equipmentComponentsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPEquipmentComponent", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtEquipmentComponent
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private string _descriptionField;

        private CtPart _partField;

        private CtShapes _shapesField;

        private CtDesignSolid[] _designSolidsField;

        private CtPorts _nozzlesField;

        private CtAttribute[] _attributesField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public string Description
        {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks />
        public CtPart Part
        {
            get => _partField;
            set => _partField = value;
        }

        /// <remarks />
        public CtShapes Shapes
        {
            get => _shapesField;
            set => _shapesField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("CDesignSolid", IsNullable = false)]
        public CtDesignSolid[] DesignSolids
        {
            get => _designSolidsField;
            set => _designSolidsField = value;
        }

        /// <remarks />
        public CtPorts Nozzles
        {
            get => _nozzlesField;
            set => _nozzlesField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Shapes", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtShapes
    {
        private CtShape[] _cPShapeField;

        private CtPrismaticShape[] _cPPrismaticShapeField;

        private CtImportedShape[] _cPuaImportedShapeOccField;

        /// <remarks />
        [XmlElementAttribute("CPShape")]
        public CtShape[] CpShape
        {
            get => _cPShapeField;
            set => _cPShapeField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPPrismaticShape")]
        public CtPrismaticShape[] CpPrismaticShape
        {
            get => _cPPrismaticShapeField;
            set => _cPPrismaticShapeField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPUAImportedShapeOcc")]
        public CtImportedShape[] CpuaImportedShapeOcc
        {
            get => _cPuaImportedShapeOccField;
            set => _cPuaImportedShapeOccField = value;
        }
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtDesignSolid))]
    [XmlIncludeAttribute(typeof(CtPrismaticShape))]
    [XmlIncludeAttribute(typeof(CtImportedShape))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPShape", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtShape : CtShapeBase
    {
        private string _nameField;

        private StRepresentation[] _representationsField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Representation", IsNullable = false)]
        public StRepresentation[] Representations
        {
            get => _representationsField;
            set => _representationsField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Representation", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StRepresentation
    {
        /// <remarks />
        SimplePhysical,

        /// <remarks />
        DetailedPhysical,

        /// <remarks />
        Insulation,

        /// <remarks />
        Operation,

        /// <remarks />
        Maintenance,

        /// <remarks />
        ReferenceGeometry,

        /// <remarks />
        Centerline
    }

    /// <remarks />
    [XmlIncludeAttribute(typeof(CtShape))]
    [XmlIncludeAttribute(typeof(CtDesignSolid))]
    [XmlIncludeAttribute(typeof(CtPrismaticShape))]
    [XmlIncludeAttribute(typeof(CtImportedShape))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CSpacePrimitive", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtShapeBase
    {
        private CtPart _partField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private CtAttribute[] _attributesField;

        /// <remarks />
        public CtPart Part
        {
            get => _partField;
            set => _partField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPPrismaticShape", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPrismaticShape : CtShape
    {
        private CtPath _pathField;

        private object _itemField;

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }

        /// <remarks />
        [XmlElementAttribute("Contour", typeof(CtContour))]
        [XmlElementAttribute("Section", typeof(CtSection))]
        public object Item
        {
            get => _itemField;
            set => _itemField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Section", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtSection : CtPart
    {
        private string _cardinalityField;

        private decimal _angleField;

        private CtAttribute[] _attributesField;

        /// <remarks />
        [XmlElementAttribute(DataType = "positiveInteger")]
        public string Cardinality
        {
            get => _cardinalityField;
            set => _cardinalityField = value;
        }

        /// <remarks />
        public decimal Angle
        {
            get => _angleField;
            set => _angleField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPUAImportedShapeOcc", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtImportedShape : CtShape
    {
        private string _definitionField;

        private string _filePathField;

        /// <remarks />
        [XmlElementAttribute(DataType = "token")]
        public string Definition
        {
            get => _definitionField;
            set => _definitionField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "token")]
        public string FilePath
        {
            get => _filePathField;
            set => _filePathField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CDesignSolid", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtDesignSolid : CtShape
    {
        private CtDesignSolidChild[] _designSolidChildrenField;

        /// <remarks />
        [XmlArrayItemAttribute("DesignSolidChild", IsNullable = false)]
        public CtDesignSolidChild[] DesignSolidChildren
        {
            get => _designSolidChildrenField;
            set => _designSolidChildrenField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("DesignSolidChild", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtDesignSolidChild
    {
        private CtShape _itemField;

        private StDesignSolidOperationType _designSolidOperationTypeField;

        /// <remarks />
        [XmlElementAttribute("CPPrismaticShape", typeof(CtPrismaticShape))]
        [XmlElementAttribute("CPShape", typeof(CtShape))]
        public CtShape Item
        {
            get => _itemField;
            set => _itemField = value;
        }

        /// <remarks />
        public StDesignSolidOperationType DesignSolidOperationType
        {
            get => _designSolidOperationTypeField;
            set => _designSolidOperationTypeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("DesignSolidOperationType", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public enum StDesignSolidOperationType
    {
        /// <remarks />
        Add,

        /// <remarks />
        Subtract,

        /// <remarks />
        Suppress
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Nozzles", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPorts
    {
        private CtPipeNozzle[] _cPPipeNozzleField;

        private CtHvacNozzle[] _cPHvacNozzleField;

        private CtCableNozzle[] _cPCableNozzleField;

        private CtConduitNozzle[] _cPConduitNozzleField;

        private CtCableTrayNozzle[] _cPCableTrayNozzleField;

        private CtFoundationPort[] _cPEqpFoundationPortField;

        /// <remarks />
        [XmlElementAttribute("CPPipeNozzle")]
        public CtPipeNozzle[] CpPipeNozzle
        {
            get => _cPPipeNozzleField;
            set => _cPPipeNozzleField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPHvacNozzle")]
        public CtHvacNozzle[] CpHvacNozzle
        {
            get => _cPHvacNozzleField;
            set => _cPHvacNozzleField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPCableNozzle")]
        public CtCableNozzle[] CpCableNozzle
        {
            get => _cPCableNozzleField;
            set => _cPCableNozzleField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPConduitNozzle")]
        public CtConduitNozzle[] CpConduitNozzle
        {
            get => _cPConduitNozzleField;
            set => _cPConduitNozzleField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPCableTrayNozzle")]
        public CtCableTrayNozzle[] CpCableTrayNozzle
        {
            get => _cPCableTrayNozzleField;
            set => _cPCableTrayNozzleField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CPEqpFoundationPort")]
        public CtFoundationPort[] CpEqpFoundationPort
        {
            get => _cPEqpFoundationPortField;
            set => _cPEqpFoundationPortField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPPipeNozzle", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPipeNozzle
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private decimal _lengthField;

        private decimal _nPdField;

        private string _nPdUnitsField;

        private string _endStandardField;

        private string _endPracticeField;

        private string _endPreparationField;

        private string _ratingPracticeField;

        private string _pressureRatingField;

        private string _schedulePracticeField;

        private string _scheduleThicknessField;

        private string _terminationClassField;

        private string _terminationSubClassField;

        private StFlowDirection _flowDirectionField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public decimal Length
        {
            get => _lengthField;
            set => _lengthField = value;
        }

        /// <remarks />
        public decimal Npd
        {
            get => _nPdField;
            set => _nPdField = value;
        }

        /// <remarks />
        public string NpdUnits
        {
            get => _nPdUnitsField;
            set => _nPdUnitsField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndStandard
        {
            get => _endStandardField;
            set => _endStandardField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndPractice
        {
            get => _endPracticeField;
            set => _endPracticeField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndPreparation
        {
            get => _endPreparationField;
            set => _endPreparationField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string RatingPractice
        {
            get => _ratingPracticeField;
            set => _ratingPracticeField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string PressureRating
        {
            get => _pressureRatingField;
            set => _pressureRatingField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string SchedulePractice
        {
            get => _schedulePracticeField;
            set => _schedulePracticeField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string ScheduleThickness
        {
            get => _scheduleThicknessField;
            set => _scheduleThicknessField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string TerminationClass
        {
            get => _terminationClassField;
            set => _terminationClassField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string TerminationSubClass
        {
            get => _terminationSubClassField;
            set => _terminationSubClassField = value;
        }

        /// <remarks />
        public StFlowDirection FlowDirection
        {
            get => _flowDirectionField;
            set => _flowDirectionField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    public enum StFlowDirection
    {
        /// <remarks />
        Undefined,

        /// <remarks />
        Out,

        /// <remarks />
        In,

        /// <remarks />
        Both,

        /// <remarks />
        Noflow
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPHvacNozzle", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtHvacNozzle
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private decimal _lengthField;

        private StCrossSectionShapeType _crossSectionShapeTypesField;

        private decimal _widthField;

        private decimal _depthField;

        private decimal _cornerRadiusField;

        private bool _cornerRadiusFieldSpecified;

        private bool _dimensionBaseOuterField;

        private bool _dimensionBaseOuterFieldSpecified;

        private decimal _connectPortOffsetField;

        private bool _connectPortOffsetFieldSpecified;

        private StFlowDirection _flowDirectionField;

        private bool _flowDirectionFieldSpecified;

        private decimal _flangeWidthField;

        private bool _flangeWidthFieldSpecified;

        private decimal _portDepthField;

        private bool _portDepthFieldSpecified;

        private decimal _thicknessField;

        private bool _thicknessFieldSpecified;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public decimal Length
        {
            get => _lengthField;
            set => _lengthField = value;
        }

        /// <remarks />
        public StCrossSectionShapeType CrossSectionShapeTypes
        {
            get => _crossSectionShapeTypesField;
            set => _crossSectionShapeTypesField = value;
        }

        /// <remarks />
        public decimal Width
        {
            get => _widthField;
            set => _widthField = value;
        }

        /// <remarks />
        public decimal Depth
        {
            get => _depthField;
            set => _depthField = value;
        }

        /// <remarks />
        public decimal CornerRadius
        {
            get => _cornerRadiusField;
            set => _cornerRadiusField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool CornerRadiusSpecified
        {
            get => _cornerRadiusFieldSpecified;
            set => _cornerRadiusFieldSpecified = value;
        }

        /// <remarks />
        public bool DimensionBaseOuter
        {
            get => _dimensionBaseOuterField;
            set => _dimensionBaseOuterField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool DimensionBaseOuterSpecified
        {
            get => _dimensionBaseOuterFieldSpecified;
            set => _dimensionBaseOuterFieldSpecified = value;
        }

        /// <remarks />
        public decimal ConnectPortOffset
        {
            get => _connectPortOffsetField;
            set => _connectPortOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ConnectPortOffsetSpecified
        {
            get => _connectPortOffsetFieldSpecified;
            set => _connectPortOffsetFieldSpecified = value;
        }

        /// <remarks />
        public StFlowDirection FlowDirection
        {
            get => _flowDirectionField;
            set => _flowDirectionField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool FlowDirectionSpecified
        {
            get => _flowDirectionFieldSpecified;
            set => _flowDirectionFieldSpecified = value;
        }

        /// <remarks />
        public decimal FlangeWidth
        {
            get => _flangeWidthField;
            set => _flangeWidthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool FlangeWidthSpecified
        {
            get => _flangeWidthFieldSpecified;
            set => _flangeWidthFieldSpecified = value;
        }

        /// <remarks />
        public decimal PortDepth
        {
            get => _portDepthField;
            set => _portDepthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool PortDepthSpecified
        {
            get => _portDepthFieldSpecified;
            set => _portDepthFieldSpecified = value;
        }

        /// <remarks />
        public decimal Thickness
        {
            get => _thicknessField;
            set => _thicknessField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ThicknessSpecified
        {
            get => _thicknessFieldSpecified;
            set => _thicknessFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    public enum StCrossSectionShapeType
    {
        /// <remarks />
        Rectangular,

        /// <remarks />
        FlatOval,

        /// <remarks />
        Round
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPCableNozzle", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCableNozzle
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private decimal _areaField;

        private bool _areaFieldSpecified;

        private decimal _diameterField;

        private string _portTypeField;

        private string _subTypeField;

        private string _terminalField;

        private string _tightnessField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public decimal Area
        {
            get => _areaField;
            set => _areaField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool AreaSpecified
        {
            get => _areaFieldSpecified;
            set => _areaFieldSpecified = value;
        }

        /// <remarks />
        public decimal Diameter
        {
            get => _diameterField;
            set => _diameterField = value;
        }

        /// <remarks />
        public string PortType
        {
            get => _portTypeField;
            set => _portTypeField = value;
        }

        /// <remarks />
        public string SubType
        {
            get => _subTypeField;
            set => _subTypeField = value;
        }

        /// <remarks />
        public string Terminal
        {
            get => _terminalField;
            set => _terminalField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string Tightness
        {
            get => _tightnessField;
            set => _tightnessField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPConduitNozzle", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtConduitNozzle
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private string _endStandardField;

        private string _endPracticeField;

        private string _endPreparationField;

        private decimal _nCdField;

        private string _nCdUnitsField;

        private string _schedulePracticeField;

        private string _scheduleThicknessField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndStandard
        {
            get => _endStandardField;
            set => _endStandardField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndPractice
        {
            get => _endPracticeField;
            set => _endPracticeField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string EndPreparation
        {
            get => _endPreparationField;
            set => _endPreparationField = value;
        }

        /// <remarks />
        public decimal Ncd
        {
            get => _nCdField;
            set => _nCdField = value;
        }

        /// <remarks />
        public string NcdUnits
        {
            get => _nCdUnitsField;
            set => _nCdUnitsField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string SchedulePractice
        {
            get => _schedulePracticeField;
            set => _schedulePracticeField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string ScheduleThickness
        {
            get => _scheduleThicknessField;
            set => _scheduleThicknessField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPCableTrayNozzle", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtCableTrayNozzle
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private decimal _actualDepthField;

        private bool _actualDepthFieldSpecified;

        private decimal _actualWidthField;

        private bool _actualWidthFieldSpecified;

        private decimal _loadDepthField;

        private bool _loadDepthFieldSpecified;

        private decimal _loadWidthField;

        private bool _loadWidthFieldSpecified;

        private decimal _nominalDepthField;

        private decimal _nominalWidthField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        public decimal ActualDepth
        {
            get => _actualDepthField;
            set => _actualDepthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ActualDepthSpecified
        {
            get => _actualDepthFieldSpecified;
            set => _actualDepthFieldSpecified = value;
        }

        /// <remarks />
        public decimal ActualWidth
        {
            get => _actualWidthField;
            set => _actualWidthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool ActualWidthSpecified
        {
            get => _actualWidthFieldSpecified;
            set => _actualWidthFieldSpecified = value;
        }

        /// <remarks />
        public decimal LoadDepth
        {
            get => _loadDepthField;
            set => _loadDepthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool LoadDepthSpecified
        {
            get => _loadDepthFieldSpecified;
            set => _loadDepthFieldSpecified = value;
        }

        /// <remarks />
        public decimal LoadWidth
        {
            get => _loadWidthField;
            set => _loadWidthField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool LoadWidthSpecified
        {
            get => _loadWidthFieldSpecified;
            set => _loadWidthFieldSpecified = value;
        }

        /// <remarks />
        public decimal NominalDepth
        {
            get => _nominalDepthField;
            set => _nominalDepthField = value;
        }

        /// <remarks />
        public decimal NominalWidth
        {
            get => _nominalWidthField;
            set => _nominalWidthField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CPEqpFoundationPort", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtFoundationPort
    {
        private string _nameField;

        private CtPoint3d _originField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        private string _foundationPortTypeField;

        private decimal _boltCircleDiameterField;

        private bool _boltCircleDiameterFieldSpecified;

        private string _numberOfHolesAlongXField;

        private string _numberOfHolesAlongYField;

        private decimal _distanceBetweenHolesAlongXField;

        private decimal _distanceBetweenHolesAlongYField;

        private decimal _footprintOffsetField;

        private bool _footprintOffsetFieldSpecified;

        private decimal _linerThicknessField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        public CtPoint3d Origin
        {
            get => _originField;
            set => _originField = value;
        }

        /// <remarks />
        public CtPoint3d VectorX
        {
            get => _vectorXField;
            set => _vectorXField = value;
        }

        /// <remarks />
        public CtPoint3d VectorY
        {
            get => _vectorYField;
            set => _vectorYField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string FoundationPortType
        {
            get => _foundationPortTypeField;
            set => _foundationPortTypeField = value;
        }

        /// <remarks />
        public decimal BoltCircleDiameter
        {
            get => _boltCircleDiameterField;
            set => _boltCircleDiameterField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool BoltCircleDiameterSpecified
        {
            get => _boltCircleDiameterFieldSpecified;
            set => _boltCircleDiameterFieldSpecified = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string NumberOfHolesAlongX
        {
            get => _numberOfHolesAlongXField;
            set => _numberOfHolesAlongXField = value;
        }

        /// <remarks />
        [XmlElementAttribute(DataType = "integer")]
        public string NumberOfHolesAlongY
        {
            get => _numberOfHolesAlongYField;
            set => _numberOfHolesAlongYField = value;
        }

        /// <remarks />
        public decimal DistanceBetweenHolesAlongX
        {
            get => _distanceBetweenHolesAlongXField;
            set => _distanceBetweenHolesAlongXField = value;
        }

        /// <remarks />
        public decimal DistanceBetweenHolesAlongY
        {
            get => _distanceBetweenHolesAlongYField;
            set => _distanceBetweenHolesAlongYField = value;
        }

        /// <remarks />
        public decimal FootprintOffset
        {
            get => _footprintOffsetField;
            set => _footprintOffsetField = value;
        }

        /// <remarks />
        [XmlIgnoreAttribute]
        public bool FootprintOffsetSpecified
        {
            get => _footprintOffsetFieldSpecified;
            set => _footprintOffsetFieldSpecified = value;
        }

        /// <remarks />
        public decimal LinerThickness
        {
            get => _linerThicknessField;
            set => _linerThicknessField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("CArea", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtSpace
    {
        private CtId[] _iDsField;

        private string _nameField;

        private CtWbsItem[] _wBsItemsField;

        private CtSpaceParent[] _spaceParentsField;

        private object[] _itemsField;

        private ItemsChoiceType1[] _itemsElementNameField;

        private CtPart _partField;

        /// <remarks />
        [XmlArrayItemAttribute("ID", IsNullable = false)]
        public CtId[] Ds
        {
            get => _iDsField;
            set => _iDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("WBSItem", IsNullable = false)]
        public CtWbsItem[] WbsItems
        {
            get => _wBsItemsField;
            set => _wBsItemsField = value;
        }

        /// <remarks />
        [XmlArrayItemAttribute("SpaceParent", IsNullable = false)]
        public CtSpaceParent[] SpaceParents
        {
            get => _spaceParentsField;
            set => _spaceParentsField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CSpacePrimitive", typeof(CtShapeBase))]
        [XmlElementAttribute("Contour", typeof(CtContour))]
        [XmlElementAttribute("MergingSpaces", typeof(CtMergingSpaces))]
        [XmlElementAttribute("Path", typeof(CtPath))]
        [XmlElementAttribute("Point1", typeof(CtPoint3d))]
        [XmlElementAttribute("Point2", typeof(CtPoint3d))]
        [XmlElementAttribute("Point3", typeof(CtPoint3d))]
        [XmlElementAttribute("Point4", typeof(CtPoint3d))]
        [XmlElementAttribute("Section", typeof(CtSection))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute]
        public ItemsChoiceType1[] ItemsElementName
        {
            get => _itemsElementNameField;
            set => _itemsElementNameField = value;
        }

        /// <remarks />
        public CtPart Part
        {
            get => _partField;
            set => _partField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("SpaceParent", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtSpaceParent
    {
        private string _nameField;

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("MergingSpaces", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtMergingSpaces
    {
        private CtSpace[] _cPInterferenceVolumeField;

        private CtSpace[] _cAreaField;

        private CtSpace[] _cZoneField;

        private CtSpace[] _cDwgVolumeField;

        /// <remarks />
        [XmlElementAttribute("CPInterferenceVolume")]
        public CtSpace[] CpInterferenceVolume
        {
            get => _cPInterferenceVolumeField;
            set => _cPInterferenceVolumeField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CArea")]
        public CtSpace[] CArea
        {
            get => _cAreaField;
            set => _cAreaField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CZone")]
        public CtSpace[] CZone
        {
            get => _cZoneField;
            set => _cZoneField = value;
        }

        /// <remarks />
        [XmlElementAttribute("CDwgVolume")]
        public CtSpace[] CDwgVolume
        {
            get => _cDwgVolumeField;
            set => _cDwgVolumeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        /// <remarks />
        CSpacePrimitive,

        /// <remarks />
        Contour,

        /// <remarks />
        MergingSpaces,

        /// <remarks />
        Path,

        /// <remarks />
        Point1,

        /// <remarks />
        Point2,

        /// <remarks />
        Point3,

        /// <remarks />
        Point4,

        /// <remarks />
        Section
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Openings", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtOpenings
    {
        private CtOpening[] _openingField;

        /// <remarks />
        [XmlElementAttribute("Opening")]
        public CtOpening[] Opening
        {
            get => _openingField;
            set => _openingField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Attributes", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtAttributes
    {
        private CtAttribute[] _attributeField;

        /// <remarks />
        [XmlElementAttribute("Attribute")]
        public CtAttribute[] Attribute
        {
            get => _attributeField;
            set => _attributeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("WBSItems", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtWbsItems
    {
        private CtWbsItem[] _wBsItemField;

        /// <remarks />
        [XmlElementAttribute("WBSItem")]
        public CtWbsItem[] WbsItem
        {
            get => _wBsItemField;
            set => _wBsItemField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("EquipmentComponents", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtEquipmentComponents
    {
        private CtEquipmentComponent[] _cPEquipmentComponentField;

        /// <remarks />
        [XmlElementAttribute("CPEquipmentComponent")]
        public CtEquipmentComponent[] CpEquipmentComponent
        {
            get => _cPEquipmentComponentField;
            set => _cPEquipmentComponentField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Representations", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtRepresentations
    {
        private StRepresentation[] _representationField;

        /// <remarks />
        [XmlElementAttribute("Representation")]
        public StRepresentation[] Representation
        {
            get => _representationField;
            set => _representationField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("DesignSolids", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtDesignSolids
    {
        private CtDesignSolid[] _cDesignSolidField;

        /// <remarks />
        [XmlElementAttribute("CDesignSolid")]
        public CtDesignSolid[] CDesignSolid
        {
            get => _cDesignSolidField;
            set => _cDesignSolidField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("DesignSolidChildren", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtDesignSolidChildren
    {
        private CtDesignSolidChild[] _designSolidChildField;

        /// <remarks />
        [XmlElementAttribute("DesignSolidChild")]
        public CtDesignSolidChild[] DesignSolidChild
        {
            get => _designSolidChildField;
            set => _designSolidChildField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Poles", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtPoles
    {
        private CtPole[] _poleField;

        /// <remarks />
        [XmlElementAttribute("Pole")]
        public CtPole[] Pole
        {
            get => _poleField;
            set => _poleField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Knots", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtKnots
    {
        private decimal[] _knotField;

        /// <remarks />
        [XmlElementAttribute("Knot")]
        public decimal[] Knot
        {
            get => _knotField;
            set => _knotField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("IDs", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtIDs
    {
        private CtId[] _idField;

        /// <remarks />
        [XmlElementAttribute("ID")]
        public CtId[] Id
        {
            get => _idField;
            set => _idField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("Parents", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtParents
    {
        private CtParent[] _parentField;

        /// <remarks />
        [XmlElementAttribute("Parent")]
        public CtParent[] Parent
        {
            get => _parentField;
            set => _parentField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:AEP.SP3D.Integration")]
    [XmlRootAttribute("SpaceParents", Namespace = "urn:AEP.SP3D.Integration", IsNullable = false)]
    public class CtSpaceParents
    {
        private CtSpaceParent[] _spaceParentField;

        /// <remarks />
        [XmlElementAttribute("SpaceParent")]
        public CtSpaceParent[] SpaceParent
        {
            get => _spaceParentField;
            set => _spaceParentField = value;
        }
    }
}