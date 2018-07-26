using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public static class TestModels
    {
        public static Component TestComponent { get; set; } = new Component()
        {
            Name = "Test",
            AngleUnit = AngleUnit.Degrees,
            DistanceUnit = DistanceUnit.Inches,
            NumberOfPlies = 1,
            CreationTimeStamp = DateTime.Parse("6/15/2018"),
            CreationProgram = "SBCA Uniform Data Standard Repository Tests",
            CreationProgramVersion = new Version(0, 1, 1).ToString(),
            Version = new Version(0, 1, 1).ToString(),

            ComponentUsages = new List<ComponentUsage>()
            {
                ComponentUsage.Roof
            },

            MaterialTypes = new List<MaterialType>()
            {
                MaterialType.Lumber,
                MaterialType.MetalPlate
            },

            Lumbers = new List<Lumber>()
            {
                new Lumber()
                {
                    Guid = Guid.Parse("9db95b90-542e-4045-ae39-42ce31ef65f8"),
                    Grade = LumberGrade.Number2,
                    Species = LumberSpecies.SouthernPine,
                    Structure = Structure.Sawn,
                    TreatmentType = "None",
                    GradingMethod = GradingMethod.Visual,
                    ActualThickness = 1.5,
                    ActualWidth = 3.5,
                    NominalThickness = "2",
                    NominalWidth = "4",
                }
            },

            MetalPlateTypes = new List<MetalPlate>()
            {
                new MetalPlate()
                {
                    Guid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                    PlateType = "AS20",
                    PlateManufacturer = "Simpson Strong Tie",
                    PlateGauge = PlateGauge.Twenty,
                    Length = 4,
                    Width = 4,
                    Thickness = 0.0356
                }
            },

            Members = new List<Member>()
            {
                new Member()
                {
                    Name = "B1",
                    MaterialGuid = Guid.Parse("9db95b90-542e-4045-ae39-42ce31ef65f8"),
                    MaterialType = MaterialType.Lumber,
                    MaterialDescription = "#2 SYP 2x4",
                    StockLength = 120,
                    MemberType = "BottomChord",
                    GrainDirection = new Vector3D ( 1.0, 0.0, 0.0 ),
                    Geometry = new Geometry()
                    {
                        Vertices = new List<Point3D> {
                                      new Point3D( 96.0, 1.5, 0.0 ),
                                      new Point3D( 0.0, 1.5, 0.0 ),
                                      new Point3D( 0.0, 1.5, 0.25 ),
                                      new Point3D( 9.75, 1.5, 3.5 ),
                                      new Point3D( 96.0, 1.5, 3.5 ),
                                      new Point3D( 96.0, 0.0, 0.0 ),
                                      new Point3D( 0.0, 0.0, 0.0 ),
                                      new Point3D( 0.0, 0.0, 0.25 ),
                                      new Point3D( 9.75, 0.0, 3.5 ),
                                      new Point3D( 96.0, 0.0, 3.5 ),
                        },

                        Faces = new List<List<int>> {
                                      new List<int>{ 0, 1, 2 },
                                      new List<int>{ 0, 2, 3 },
                                      new List<int>{ 0, 3, 4 },
                                      new List<int>{ 0, 5, 6 },
                                      new List<int>{ 0, 6, 15 },
                                      new List<int>{ 1, 6, 7 },
                                      new List<int>{ 1, 7, 2 },
                                      new List<int>{ 2, 7, 8 },
                                      new List<int>{ 2, 8, 3 },
                                      new List<int>{ 3, 8, 9 },
                                      new List<int>{ 3, 9, 4 },
                                      new List<int>{ 4, 9, 5 },
                                      new List<int>{ 4, 5, 0 },
                                      new List<int>{ 5, 9, 8 },
                                      new List<int>{ 5, 8, 7 },
                                      new List<int>{ 5, 7, 6 },
                        },
                    },
                }
            },

            ConnectorSets = new List<Connector[]>()
            {
              new []
              {
                    new Connector()
                    {
                        Name = "1",
                        MaterialDescription = "AS20 4x4",
                        MaterialGuid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                        Angle = 0.0,
                        Center = new Point3D( 60.0, 3.5, 1.5 ),
                        NormalDirection = new Vector3D( 0.0, 0.0, 1.0 ),
                                        },
                    new Connector()
                    {
                        Name = "1",
                        MaterialDescription = "AS20 4x4",
                        MaterialGuid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                        Angle = 0.0,
                        Center = new Point3D( 60.0, 3.5, 1.5 ),
                        NormalDirection = new Vector3D (0.0, 0.0, -1.0 ),
                    }
              },
            },

            Bearings = new List<Bearing>()
            {
                new Bearing()
                {
                    Name = "A",
                    Center = new Point3D  (1.75, 0, .75 ),
                    Depth = 1.5,
                    Width = 3.5,
                    BearingType = "Double Wall Plate",
                },

                new Bearing()
                {
                    Name = "B",
                    Center = new Point3D ( 95.25, 0, .75 ),
                    Depth = 1.5,
                    Width = 3.5,
                    BearingType = "Double Wall Plate",
                }
            },

            Hangers = new List<Hanger>()
            {
                new Hanger()
                {
                    Name = "Hanger 1",
                    Center = new Point3D ( 30.0, 0, 1.5 ),
                    Depth = 3.5,
                    Width = 3.5,
                    Height = 3.5,
                }
            },
        };

    }
}
