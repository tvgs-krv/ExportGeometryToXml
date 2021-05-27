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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Objects", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtObjects
    {
        private CtSpace[] _cAreaField;

        private CtSpace[] _cPInterferenceVolumeField;

        private CtEquipment[] _cPSmartEquipmentField;

        private CtCoordinateSystem[] _cSpgCoordinateSystemField;

        private CtHandrail[] _cSpsHandrailField;

        private CtMemberPartCurve[] _cSpsMemberPartCurveField;

        private CtMemberPartPrismatic[] _cSpsMemberPartPrismaticField;
        private CtSlab[] _cSpsSlabEntityField;

        private CtSpace[] _cZoneField;

        private CtWall[] _sPsWallPartField;

        /// <remarks />
        [XmlElement("CSPSSlabEntity")]
        public CtSlab[] CspsSlabEntity
        {
            get => _cSpsSlabEntityField;
            set => _cSpsSlabEntityField = value;
        }

        /// <remarks />
        [XmlElement("SPSWallPart")]
        public CtWall[] SpsWallPart
        {
            get => _sPsWallPartField;
            set => _sPsWallPartField = value;
        }

        /// <remarks />
        [XmlElement("CSPSMemberPartPrismatic")]
        public CtMemberPartPrismatic[] CspsMemberPartPrismatic
        {
            get => _cSpsMemberPartPrismaticField;
            set => _cSpsMemberPartPrismaticField = value;
        }

        /// <remarks />
        [XmlElement("CSPSMemberPartCurve")]
        public CtMemberPartCurve[] CspsMemberPartCurve
        {
            get => _cSpsMemberPartCurveField;
            set => _cSpsMemberPartCurveField = value;
        }

        /// <remarks />
        [XmlElement("CSPGCoordinateSystem")]
        public CtCoordinateSystem[] CspgCoordinateSystem
        {
            get => _cSpgCoordinateSystemField;
            set => _cSpgCoordinateSystemField = value;
        }

        /// <remarks />
        [XmlElement("CSPSHandrail")]
        public CtHandrail[] CspsHandrail
        {
            get => _cSpsHandrailField;
            set => _cSpsHandrailField = value;
        }

        /// <remarks />
        [XmlElement("CPSmartEquipment")]
        public CtEquipment[] CpSmartEquipment
        {
            get => _cPSmartEquipmentField;
            set => _cPSmartEquipmentField = value;
        }

        /// <remarks />
        [XmlElement("CPInterferenceVolume")]
        public CtSpace[] CpInterferenceVolume
        {
            get => _cPInterferenceVolumeField;
            set => _cPInterferenceVolumeField = value;
        }

        /// <remarks />
        [XmlElement("CArea")]
        public CtSpace[] CArea
        {
            get => _cAreaField;
            set => _cAreaField = value;
        }

        /// <remarks />
        [XmlElement("CZone")]
        public CtSpace[] CZone
        {
            get => _cZoneField;
            set => _cZoneField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CSPSSlabEntity", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtSlab
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;
        private string _oIdField;

        private CtParent[] _parentsField;

        private decimal _angleField;

        private bool _angleFieldSpecified;

        private StSlabReferenceDirection _boundProjDirectionField;

        private bool _boundProjDirectionFieldSpecified;

        private StSlabReferenceDirection _boundSlopeDirectionField;

        private bool _boundSlopeDirectionFieldSpecified;

        private CtContour _contourField;

        private string _coordinateSystemField;

        private StFacePosition _facePositionField;

        private string _nameField;

        private CtPoint3d _normalField;

        private decimal _normalOffsetField;

        private bool _normalOffsetFieldSpecified;

        private CtOpening[] _openingsField;

        private decimal _slopeField;

        private bool _slopeFieldSpecified;

        private CtStructureComposition _structureCompositionField;

        private CtStructureType _structureTypeField;

        private StSlabReferenceDirection _thickeningDirectionField;

        private bool _thickeningDirectionFieldSpecified;

        private decimal _thicknessField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        [XmlArrayItem("Parent", IsNullable = false)]
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
        [XmlIgnore]
        public bool NormalOffsetSpecified
        {
            get => _normalOffsetFieldSpecified;
            set => _normalOffsetFieldSpecified = value;
        }

        /// <remarks />
        public decimal Angle
        {
            get => _angleField;
            set => _angleField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool AngleSpecified
        {
            get => _angleFieldSpecified;
            set => _angleFieldSpecified = value;
        }

        /// <remarks />
        public decimal Slope
        {
            get => _slopeField;
            set => _slopeField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool SlopeSpecified
        {
            get => _slopeFieldSpecified;
            set => _slopeFieldSpecified = value;
        }

        /// <remarks />
        public StSlabReferenceDirection BoundProjDirection
        {
            get => _boundProjDirectionField;
            set => _boundProjDirectionField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool BoundProjDirectionSpecified
        {
            get => _boundProjDirectionFieldSpecified;
            set => _boundProjDirectionFieldSpecified = value;
        }

        /// <remarks />
        public StSlabReferenceDirection BoundSlopeDirection
        {
            get => _boundSlopeDirectionField;
            set => _boundSlopeDirectionField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool BoundSlopeDirectionSpecified
        {
            get => _boundSlopeDirectionFieldSpecified;
            set => _boundSlopeDirectionFieldSpecified = value;
        }

        /// <remarks />
        public StSlabReferenceDirection ThickeningDirection
        {
            get => _thickeningDirectionField;
            set => _thickeningDirectionField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool ThickeningDirectionSpecified
        {
            get => _thickeningDirectionFieldSpecified;
            set => _thickeningDirectionFieldSpecified = value;
        }

        /// <remarks />
        public CtStructureType StructureType
        {
            get => _structureTypeField;
            set => _structureTypeField = value;
        }

        /// <remarks />
        public CtStructureComposition StructureComposition
        {
            get => _structureCompositionField;
            set => _structureCompositionField = value;
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
        public CtContour Contour
        {
            get => _contourField;
            set => _contourField = value;
        }

        /// <remarks />
        [XmlArrayItem("Opening", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Attribute", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtAttribute
    {
        private string _attributeField;

        private string _interfaceField;
        private string _relationNavigationPathField;

        private string _valueField;

        /// <remarks />
        [XmlAttribute]
        public string RelationNavigationPath
        {
            get => _relationNavigationPathField;
            set => _relationNavigationPathField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Interface
        {
            get => _interfaceField;
            set => _interfaceField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Attribute
        {
            get => _attributeField;
            set => _attributeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }

    /// <remarks />
    [XmlInclude(typeof(CtMemberPartCurve))]
    [XmlInclude(typeof(CtMemberPartPrismatic))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    public class CtMemberPart
    {
        private CtAttribute[] _attributesField;

        private CtCrossSection _crossSectionField;

        private string[] _eIDsField;

        private CtMaterial _materialField;

        private string _memberTypeCategoryField;

        private string _memberTypeField;

        private string _nameField;
        private string _oIdField;

        private CtParent[] _parentsField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        [XmlArrayItem("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "positiveInteger")]
        public string MemberTypeCategory
        {
            get => _memberTypeCategoryField;
            set => _memberTypeCategoryField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "positiveInteger")]
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
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Parent", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtParent
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private StSystemType _systemTypeField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("SystemType", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public enum StSystemType
    {
        /// <remarks />
        CpAreaSystem,

        /// <remarks />
        CpConduitSystem,

        /// <remarks />
        CpDuctingSystem,

        /// <remarks />
        CpElectricalSystem,

        /// <remarks />
        CpHullOufittingSystem,

        /// <remarks />
        CpMachinerySystem,

        /// <remarks />
        CpmSystem,

        /// <remarks />
        CpPipelineSystem,

        /// <remarks />
        CpPipingSystem,

        /// <remarks />
        CpStructuralSystem,

        /// <remarks />
        CpUnitSystem
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Material", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtMaterial
    {
        private string _gradeField;
        private string _typeField;

        /// <remarks />
        [XmlAttribute]
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Grade
        {
            get => _gradeField;
            set => _gradeField = value;
        }
    }

    /// <remarks />
    [XmlInclude(typeof(CtStructureCrossSection))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CrossSection", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtCrossSection
    {
        private decimal _angleField;

        private bool _angleFieldSpecified;
        private string _cardinalPointField;

        private string _nameField;

        private string _referenceStandardField;

        private bool _reflectField;

        private string _typeField;

        /// <remarks />
        [XmlElement(DataType = "integer")]
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
        public decimal Angle
        {
            get => _angleField;
            set => _angleField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool AngleSpecified
        {
            get => _angleFieldSpecified;
            set => _angleFieldSpecified = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string ReferenceStandard
        {
            get => _referenceStandardField;
            set => _referenceStandardField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlAttribute]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("StartPoint", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPoint3d
    {
        private decimal _xField;

        private decimal _yField;

        private decimal _zField;

        /// <remarks />
        [XmlAttribute]
        public decimal X
        {
            get => _xField;
            set => _xField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public decimal Y
        {
            get => _yField;
            set => _yField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public decimal Z
        {
            get => _zField;
            set => _zField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("BoundProjDirection", Namespace = "urn:S3DIntegration", IsNullable = false)]
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
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("StructureType", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtStructureType
    {
        private string _partNumberField;

        /// <remarks />
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("StructureComposition", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtStructureComposition
    {
        private CtLayer[] _layerField;

        private string _partNumberField;

        /// <remarks />
        [XmlElement("Layer")]
        public CtLayer[] Layer
        {
            get => _layerField;
            set => _layerField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Layer", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtLayer
    {
        private string _idField;

        private bool _isReferenceField;
        private CtMaterial _materialField;

        private string _partNumberField;

        private decimal _thicknessField;

        /// <remarks />
        public CtMaterial Material
        {
            get => _materialField;
            set => _materialField = value;
        }

        /// <remarks />
        public decimal Thickness
        {
            get => _thicknessField;
            set => _thicknessField = value;
        }

        /// <remarks />
        public bool IsReference
        {
            get => _isReferenceField;
            set => _isReferenceField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "positiveInteger")]
        public string Id
        {
            get => _idField;
            set => _idField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("FacePosition", Namespace = "urn:S3DIntegration", IsNullable = false)]
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
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Contour", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtContour
    {
        private object[] _itemsField;

        /// <remarks />
        [XmlElement("Arc3d", typeof(CtArc3d))]
        [XmlElement("Circle3d", typeof(CtCircle3d))]
        [XmlElement("Line3d", typeof(CtLine3d))]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Arc3d", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtArc3d
    {
        private CtPoint3d _alongPointField;

        private CtPoint3d _endPointField;
        private CtPoint3d _startPointField;

        /// <remarks />
        public CtPoint3d StartPoint
        {
            get => _startPointField;
            set => _startPointField = value;
        }

        /// <remarks />
        public CtPoint3d AlongPoint
        {
            get => _alongPointField;
            set => _alongPointField = value;
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Circle3d", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtCircle3d
    {
        private CtPoint3d _centerPointField;

        private CtPoint3d _normalField;

        private decimal _radiusField;

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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Line3d", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtLine3d
    {
        private CtPoint3d _endPointField;
        private CtPoint3d _startPointField;

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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Opening", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtOpening
    {
        private CtAttribute[] _attributesField;

        private CtContour _contourField;

        private decimal _cuttingDepthField;

        private CtPoint3d _directionField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private StOpeningGeometry _typeField;

        private bool _typeFieldSpecified;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
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

        /// <remarks />
        [XmlAttribute]
        public StOpeningGeometry Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public bool TypeSpecified
        {
            get => _typeFieldSpecified;
            set => _typeFieldSpecified = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration")]
    public enum StOpeningGeometry
    {
        /// <remarks />
        Sketch2d,

        /// <remarks />
        Boundaries,

        /// <remarks />
        ExternalSymbol
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("SPSWallPart", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtWall
    {
        private CtAttribute[] _attributesField;

        private string _coordinateSystemField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private CtOpening[] _openingsField;

        private CtParent[] _parentsField;

        private CtPath _pathField;

        private CtStructureComposition _structureCompositionField;

        private CtStructureCrossSection _structureCrossSectionField;

        private CtStructureType _structureTypeField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        [XmlArrayItem("Parent", IsNullable = false)]
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
        public CtStructureType StructureType
        {
            get => _structureTypeField;
            set => _structureTypeField = value;
        }

        /// <remarks />
        public CtStructureComposition StructureComposition
        {
            get => _structureCompositionField;
            set => _structureCompositionField = value;
        }

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

        /// <remarks />
        [XmlArrayItem("Opening", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("StructureCrossSection", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtStructureCrossSection : CtCrossSection
    {
        private decimal _heightField;
        private decimal _horisontalOffsetField;

        private bool _horisontalOffsetFieldSpecified;

        private decimal _thicknessField;

        private decimal _verticalOffsetField;

        private bool _verticalOffsetFieldSpecified;

        /// <remarks />
        public decimal HorisontalOffset
        {
            get => _horisontalOffsetField;
            set => _horisontalOffsetField = value;
        }

        /// <remarks />
        [XmlIgnore]
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
        [XmlIgnore]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Path", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPath
    {
        private object[] _itemsField;

        /// <remarks />
        [XmlElement("Arc3d", typeof(CtArc3d))]
        [XmlElement("Line3d", typeof(CtLine3d))]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CSPSMemberPartPrismatic", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtMemberPartPrismatic : CtMemberPart
    {
        private CtOpening[] _openingsField;
        private CtLine3d _pointsField;

        /// <remarks />
        public CtLine3d Points
        {
            get => _pointsField;
            set => _pointsField = value;
        }

        /// <remarks />
        [XmlArrayItem("Opening", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CSPSMemberPartCurve", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtMemberPartCurve : CtMemberPart
    {
        private CtOpening[] _openingsField;
        private CtPath _pathField;

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }

        /// <remarks />
        [XmlArrayItem("Opening", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CSPGCoordinateSystem", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtCoordinateSystem
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private ItemsChoiceType[] _itemsElementNameField;

        private CtPlanes[] _itemsField;

        private string _nameField;
        private string _oIdField;

        private CtPoint3d _originField;

        private CtParent[] _parentsField;

        private CtPlane[] _planesZField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
        [XmlArrayItem("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        [XmlArrayItem("Plane", IsNullable = false)]
        public CtPlane[] PlanesZ
        {
            get => _planesZField;
            set => _planesZField = value;
        }

        /// <remarks />
        [XmlElement("PlanesCylindrical", typeof(CtPlanes))]
        [XmlElement("PlanesRadial", typeof(CtPlanes))]
        [XmlElement("PlanesX", typeof(CtPlanes))]
        [XmlElement("PlanesY", typeof(CtPlanes))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public CtPlanes[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Plane", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPlane
    {
        private string _nameField;

        private decimal _offsetField;
        private string _oIdField;

        private string _typeIdField;

        public CtPlane()
        {
            _typeIdField = "1";
        }

        /// <remarks />
        [XmlAttribute(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlAttribute(DataType = "positiveInteger")]
        [DefaultValue("1")]
        public string TypeId
        {
            get => _typeIdField;
            set => _typeIdField = value;
        }

        /// <remarks />
        [XmlAttribute]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("PlanesX", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPlanes
    {
        private CtPlane[] _planeField;

        /// <remarks />
        [XmlElement("Plane")]
        public CtPlane[] Plane
        {
            get => _planeField;
            set => _planeField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration", IncludeInSchema = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CSPSHandrail", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtHandrail
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private CtParent[] _parentsField;

        private string _partNumberField;

        private CtPath _pathField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        [XmlArrayItem("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPSmartEquipment", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtEquipment : CtEquipmentComponent
    {
        private CtEquipmentComponent[] _equipmentComponentsField;
        private CtParent[] _parentsField;

        /// <remarks />
        [XmlArrayItem("Parent", IsNullable = false)]
        public CtParent[] Parents
        {
            get => _parentsField;
            set => _parentsField = value;
        }

        /// <remarks />
        [XmlArrayItem("CPEquipmentComponent", IsNullable = false)]
        public CtEquipmentComponent[] EquipmentComponents
        {
            get => _equipmentComponentsField;
            set => _equipmentComponentsField = value;
        }

        #region Users

        #endregion
    }

    /// <remarks />
    [XmlInclude(typeof(CtEquipment))]
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPEquipmentComponent", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtEquipmentComponent
    {
        private string _partNumber;

        private CtAttribute[] _attributesField;

        private CtDesignSolid[] _designSolidsField;

        private string[] _eIDsField;

        private ItemChoiceType _itemElementNameField;

        private string _itemField;

        private string _nameField;

        private CtNozzles _nozzlesField;
        private string _oIdField;

        private CtPoint3d _originField;

        private CtShapes _shapesField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }


        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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

        public string PartNumber
        {
            get => _partNumber;
            set => _partNumber = value;
        }

        /// <remarks />
        [XmlElement("PartClass", typeof(string), DataType = "token")]
        //[XmlElement("PartNumber", typeof(string), DataType = "token")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get => _itemField;
            set => _itemField = value;
        }

        /// <remarks />
        [XmlIgnore]
        public ItemChoiceType ItemElementName
        {
            get => _itemElementNameField;
            set => _itemElementNameField = value;
        }

        /// <remarks />
        public CtShapes Shapes
        {
            get => _shapesField;
            set => _shapesField = value;
        }

        /// <remarks />
        [XmlArrayItem("CDesignSolid", IsNullable = false)]
        public CtDesignSolid[] DesignSolids
        {
            get => _designSolidsField;
            set => _designSolidsField = value;
        }

        /// <remarks />
        public CtNozzles Nozzles
        {
            get => _nozzlesField;
            set => _nozzlesField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks />
        PartClass,

        /// <remarks />
        PartNumber
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Shapes", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtShapes
    {
        private CtPrismaticShape[] _cPPrismaticShapeField;
        private CtShape[] _cPShapeField;

        private CtImportedShape[] _cPuaImportedShapeOccField;

        /// <remarks />
        [XmlElement("CPShape")]
        public CtShape[] CpShape
        {
            get => _cPShapeField;
            set => _cPShapeField = value;
        }

        /// <remarks />
        [XmlElement("CPPrismaticShape")]
        public CtPrismaticShape[] CpPrismaticShape
        {
            get => _cPPrismaticShapeField;
            set => _cPPrismaticShapeField = value;
        }

        /// <remarks />
        [XmlElement("CPUAImportedShapeOcc")]
        public CtImportedShape[] CpuaImportedShapeOcc
        {
            get => _cPuaImportedShapeOccField;
            set => _cPuaImportedShapeOccField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPShape", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtShape
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private CtPoint3d _originField;

        private StShapePart _partNumberField;

        private StRepresentation[] _representationsField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
        [XmlArrayItem("Representation", IsNullable = false)]
        public StRepresentation[] Representations
        {
            get => _representationsField;
            set => _representationsField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public StShapePart PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Representation", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public enum StRepresentation
    {
        /// <remarks />
        [XmlEnum("Simple Physical")] SimplePhysical,

        /// <remarks />
        [XmlEnum("Detailed Physical")] DetailedPhysical,

        /// <remarks />
        Insulation,

        /// <remarks />
        Operation,

        /// <remarks />
        Maintenance,

        /// <remarks />
        [XmlEnum("Reference Geometry")] ReferenceGeometry,

        /// <remarks />
        Centerline
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration")]
    public enum StShapePart
    {
        /// <remarks />
        [XmlEnum("DatumShape 001")] DatumShape001,

        /// <remarks />
        [XmlEnum("CircularTori 001")] CircularTori001,

        /// <remarks />
        [XmlEnum("Sphere 001")] Sphere001,

        /// <remarks />
        [XmlEnum("EccentricCone 001")] EccentricCone001,

        /// <remarks />
        [XmlEnum("RtCircularCone 001")] RtCircularCone001,

        /// <remarks />
        [XmlEnum("TriangularSolid 001")] TriangularSolid001,

        /// <remarks />
        [XmlEnum("OctogonalSolid 001")] OctogonalSolid001,

        /// <remarks />
        [XmlEnum("HexagonalSolid 001")] HexagonalSolid001,

        /// <remarks />
        [XmlEnum("RectangularSolid 001")] RectangularSolid001,

        /// <remarks />
        [XmlEnum("Platform1 001")] Platform1001,

        /// <remarks />
        [XmlEnum("Platform2 001")] Platform2001,

        /// <remarks />
        [XmlEnum("SemiEllipticalHead 001")] SemiEllipticalHead001,

        /// <remarks />
        [XmlEnum("RectangularTorus 001")] RectangularTorus001,

        /// <remarks />
        [XmlEnum("TruncatedRectangularPrism 001")]
        TruncatedRectangularPrism001,

        /// <remarks />
        [XmlEnum("EccentricTransitionElement 001")]
        EccentricTransitionElement001,

        /// <remarks />
        [XmlEnum("TransitionElement 001")] TransitionElement001,

        /// <remarks />
        [XmlEnum("EccentricRectangularPrism 001")]
        EccentricRectangularPrism001,

        /// <remarks />
        [XmlEnum("RtCircularCylinder 001")] RtCircularCylinder001
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPPrismaticShape", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPrismaticShape
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private object _itemField;

        private string _nameField;
        private string _oIdField;

        private CtPoint3d _originField;

        private CtPath _pathField;

        private StRepresentation[] _representationsField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
        [XmlArrayItem("Representation", IsNullable = false)]
        public StRepresentation[] Representations
        {
            get => _representationsField;
            set => _representationsField = value;
        }

        /// <remarks />
        public CtPath Path
        {
            get => _pathField;
            set => _pathField = value;
        }

        /// <remarks />
        [XmlElement("Contour", typeof(CtContour))]
        [XmlElement("Section", typeof(CtSection))]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Section", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtSection
    {
        private decimal _angleField;
        private string _cardinalityField;

        private string _partNumberField;

        /// <remarks />
        [XmlElement(DataType = "positiveInteger")]
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
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPUAImportedShapeOcc", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtImportedShape
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _filePathField;

        private string _nameField;
        private string _oIdField;

        private CtPoint3d _originField;

        private StRepresentation[] _representationsField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
        [XmlArrayItem("Representation", IsNullable = false)]
        public StRepresentation[] Representations
        {
            get => _representationsField;
            set => _representationsField = value;
        }

        /// <remarks />
        [XmlElement(DataType = "token")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CDesignSolid", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtDesignSolid
    {
        private CtAttribute[] _attributesField;

        private CtDesignSolidChild[] _designSolidChildrenField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        private CtPoint3d _originField;

        private StRepresentation[] _representationsField;

        private CtPoint3d _vectorXField;

        private CtPoint3d _vectorYField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
        [XmlArrayItem("Representation", IsNullable = false)]
        public StRepresentation[] Representations
        {
            get => _representationsField;
            set => _representationsField = value;
        }

        /// <remarks />
        [XmlArrayItem("DesignSolidChild", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("DesignSolidChild", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtDesignSolidChild
    {
        private StDesignSolidOperationType _designSolidOperationTypeField;
        private object _itemField;

        /// <remarks />
        [XmlElement("CPPrismaticShape", typeof(CtPrismaticShape))]
        [XmlElement("CPShape", typeof(CtShape))]
        public object Item
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("DesignSolidOperationType", Namespace = "urn:S3DIntegration", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Nozzles", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtNozzles
    {
        private CtCableNozzle[] _cPCableNozzleField;

        private CtCableTrayNozzle[] _cPCableTrayNozzleField;

        private CtConduitNozzle[] _cPConduitNozzleField;

        private CtFoundationPort[] _cPEqpFoundationPortField;

        private CtHvacNozzle[] _cPHvacNozzleField;
        private CtPipeNozzle[] _cPPipeNozzleField;

        /// <remarks />
        [XmlElement("CPPipeNozzle")]
        public CtPipeNozzle[] CpPipeNozzle
        {
            get => _cPPipeNozzleField;
            set => _cPPipeNozzleField = value;
        }

        /// <remarks />
        [XmlElement("CPHvacNozzle")]
        public CtHvacNozzle[] CpHvacNozzle
        {
            get => _cPHvacNozzleField;
            set => _cPHvacNozzleField = value;
        }

        /// <remarks />
        [XmlElement("CPCableNozzle")]
        public CtCableNozzle[] CpCableNozzle
        {
            get => _cPCableNozzleField;
            set => _cPCableNozzleField = value;
        }

        /// <remarks />
        [XmlElement("CPConduitNozzle")]
        public CtConduitNozzle[] CpConduitNozzle
        {
            get => _cPConduitNozzleField;
            set => _cPConduitNozzleField = value;
        }

        /// <remarks />
        [XmlElement("CPCableTrayNozzle")]
        public CtCableTrayNozzle[] CpCableTrayNozzle
        {
            get => _cPCableTrayNozzleField;
            set => _cPCableTrayNozzleField = value;
        }

        /// <remarks />
        [XmlElement("CPEqpFoundationPort")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPPipeNozzle", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtPipeNozzle
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPHvacNozzle", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtHvacNozzle
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPCableNozzle", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtCableNozzle
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPConduitNozzle", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtConduitNozzle
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPCableTrayNozzle", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtCableTrayNozzle
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CPEqpFoundationPort", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtFoundationPort
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("CArea", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtSpace
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private ItemsChoiceType2[] _itemsElementNameField;

        private object[] _itemsField;

        private string _nameField;
        private string _oIdField;

        private string _partNumberField;

        private CtSpaceParent[] _spaceParentsField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
        public CtAttribute[] Attributes
        {
            get => _attributesField;
            set => _attributesField = value;
        }

        /// <remarks />
        [XmlArrayItem("SpaceParent", IsNullable = false)]
        public CtSpaceParent[] SpaceParents
        {
            get => _spaceParentsField;
            set => _spaceParentsField = value;
        }

        /// <remarks />
        [XmlElement("CSpacePrimitive", typeof(CtShape))]
        [XmlElement("Contour", typeof(CtContour))]
        [XmlElement("MergingSpaces", typeof(CtMergingSpaces))]
        [XmlElement("Path", typeof(CtPath))]
        [XmlElement("Point1", typeof(CtPoint3d))]
        [XmlElement("Point2", typeof(CtPoint3d))]
        [XmlElement("Point3", typeof(CtPoint3d))]
        [XmlElement("Point4", typeof(CtPoint3d))]
        [XmlElement("Section", typeof(CtSection))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType2[] ItemsElementName
        {
            get => _itemsElementNameField;
            set => _itemsElementNameField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string PartNumber
        {
            get => _partNumberField;
            set => _partNumberField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("SpaceParent", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtSpaceParent
    {
        private CtAttribute[] _attributesField;

        private string[] _eIDsField;

        private string _nameField;
        private string _oIdField;

        /// <remarks />
        [XmlElement(DataType = "token")]
        public string Oid
        {
            get => _oIdField;
            set => _oIdField = value;
        }

        /// <remarks />
        [XmlArrayItem("EID", IsNullable = false)]
        public string[] EiDs
        {
            get => _eIDsField;
            set => _eIDsField = value;
        }

        /// <remarks />
        public string Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArrayItem("Attribute", IsNullable = false)]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("MergingSpaces", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtMergingSpaces
    {
        private ItemsChoiceType1[] _itemsElementNameField;
        private CtSpace[] _itemsField;

        /// <remarks />
        [XmlElement("CArea", typeof(CtSpace))]
        [XmlElement("CPInterferenceVolume", typeof(CtSpace))]
        [XmlElement("CZone", typeof(CtSpace))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public CtSpace[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName
        {
            get => _itemsElementNameField;
            set => _itemsElementNameField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        /// <remarks />
        CArea,

        /// <remarks />
        CpInterferenceVolume,

        /// <remarks />
        CZone
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [XmlType(Namespace = "urn:S3DIntegration", IncludeInSchema = false)]
    public enum ItemsChoiceType2
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Openings", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtOpenings
    {
        private CtOpening[] _openingField;

        /// <remarks />
        [XmlElement("Opening")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Attributes", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtAttributes
    {
        private CtAttribute[] _attributeField;

        /// <remarks />
        [XmlElement("Attribute")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("EquipmentComponents", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtEquipmentComponents
    {
        private CtEquipmentComponent[] _cPEquipmentComponentField;

        /// <remarks />
        [XmlElement("CPEquipmentComponent")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Representations", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtRepresentations
    {
        private StRepresentation[] _representationField;

        /// <remarks />
        [XmlElement("Representation")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("DesignSolids", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtDesignSolids
    {
        private CtDesignSolid[] _cDesignSolidField;

        /// <remarks />
        [XmlElement("CDesignSolid")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("DesignSolidChildren", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtDesignSolidChildren
    {
        private CtDesignSolidChild[] _designSolidChildField;

        /// <remarks />
        [XmlElement("DesignSolidChild")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("EIDs", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtEiDs
    {
        private string[] _eIdField;

        /// <remarks />
        [XmlElement("EID")]
        public string[] Eid
        {
            get => _eIdField;
            set => _eIdField = value;
        }
    }

    /// <remarks />
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("Parents", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtParents
    {
        private CtParent[] _parentField;

        /// <remarks />
        [XmlElement("Parent")]
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
    [XmlType(Namespace = "urn:S3DIntegration")]
    [XmlRoot("SpaceParents", Namespace = "urn:S3DIntegration", IsNullable = false)]
    public class CtSpaceParents
    {
        private CtSpaceParent[] _spaceParentField;

        /// <remarks />
        [XmlElement("SpaceParent")]
        public CtSpaceParent[] SpaceParent
        {
            get => _spaceParentField;
            set => _spaceParentField = value;
        }
    }
}