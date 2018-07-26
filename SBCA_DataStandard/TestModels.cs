using SBCA_DataStandard.Enums;
using SBCA_DataStandard.Materials;
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
            Guid = new Guid("DCBA9337-2417-46F4-82ED-27CFD6BB5E4B"),
            AngleUnit = AngleUnit.Degrees,
            DistanceUnit = DistanceUnit.Inches,
            NumberOfPlies = 1,
            CreationTimeStamp = DateTime.Parse("6/15/2018"),
            CreationProgram = "SBCA Uniform Data Standard Repository Tests",
            CreationProgramVersion = new Version(0, 1, 2).ToString(),
            Version = new Version(0, 1, 2).ToString(),

            ComponentUsages = new List<ComponentUsage>()
            {
                ComponentUsage.Roof
            },

            MaterialTypeCollections = new List<MaterialTypeCollection>()
            {
                new MaterialTypeCollection("ConnectorPlateTypes", MaterialType.ConnectorPlate, TestConnectorPlateTypes.ToList<Material>()),
                new MaterialTypeCollection("Lumbers", MaterialType.Lumber, TestLumbers.ToList<Material>()),
                new MaterialTypeCollection("Hangers", MaterialType.Hanger, TestHangers.ToList<Material>()),
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
                    Orientation = new Vector3D ( 1.0, 0.0, 0.0 ),
                    MemberTypes = new List<MemberType>(){ MemberType.BottomChord },
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

            HardwareSets = new List<HardwareSet>()
            {
                new HardwareSet()
                {
                    Guid = new Guid("D1834CE8-4BDA-44A0-AD97-B277D037DCFE"),
                    Name = "Joint 1",
                    HardwarePieces = new List<Hardware>()
                    {
                        new Hardware()
                        {
                            Name = "1",
                            MaterialDescription = "AS20 4x4",
                            MaterialType = MaterialType.ConnectorPlate,
                            MaterialGuid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                            Angle = 0.0,
                            Center = new Point3D( 60.0, 3.5, 1.5 ),
                            NormalDirection = new Vector3D( 0.0, 0.0, 1.0 ),
                                            },
                        new Hardware()
                        {
                            Name = "1",
                            MaterialDescription = "AS20 4x4",
                            MaterialType = MaterialType.ConnectorPlate,
                            MaterialGuid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                            Angle = 0.0,
                            Center = new Point3D( 60.0, 3.5, 1.5 ),
                            NormalDirection = new Vector3D (0.0, 0.0, -1.0 ),
                        }
                    },
                }
            },

            Bearings = new List<Bearing>()
            {
                new Bearing()
                {
                    Guid = Guid.Parse("1E9E3783-E616-4511-B62B-5DD5EDA62FCE"),
                    Description = "Hanger",
                    AssociatedHardwareSetGuid = Guid.Parse("2E6993B2-888A-40D9-B40D-468A836AAA13"),
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
                    }
                },

                new Bearing()
                {
                    Guid = Guid.Parse("93067B38-4823-4D07-83CB-9FDD090B81D7"),
                    Description = "Double Wall Plate",
                    AssociatedHardwareSetGuid = Guid.Parse("9db95b90-542e-4045-ae39-42ce31ef65f8"),
                    Geometry = new Geometry()
                    {
                        Vertices = new List<Point3D> {
                                      new Point3D( 0.0, 1.5, 0.0 ),
                                      new Point3D( 0.0, 1.5, 0.25 ),
                                      new Point3D( 9.75, 1.5, 3.5 ),
                                      new Point3D( 0.0, 0.0, 0.0 ),
                                      new Point3D( 0.0, 0.0, 0.25 ),
                                      new Point3D( 9.75, 0.0, 3.5 ),
                        },

                        Faces = new List<List<int>> {
                                      new List<int>{ 0, 1, 2 },
                                      new List<int>{ 0, 2, 3 },
                                      new List<int>{ 0, 3, 4 },
                                      new List<int>{ 0, 5, 6 },
                        },
                    }
                }
            },
        };

        public static IEnumerable<Lumber> TestLumbers => new List<Lumber>()
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
        };

        public static IEnumerable<ConnectorPlate> TestConnectorPlateTypes => new List<ConnectorPlate>()
        {
            new ConnectorPlate()
            {
                Guid = Guid.Parse("92862168-2B8C-42F6-9A68-68EDAABEBC29"),
                PlateType = "AS20",
                PlateManufacturer = PlateManufacturer.Simpson,
                PlateGauge = PlateGauge.Twenty,
                Length = 4,
                Width = 4,
                Thickness = 0.0356
            }
        };

        public static IEnumerable<Hanger> TestHangers => new List<Hanger>()
        {
            new Hanger()
            {
                Guid = Guid.Parse("2E6993B2-888A-40D9-B40D-468A836AAA13"),
                Description = "Hanger 1",
            }
        };
    }
}
