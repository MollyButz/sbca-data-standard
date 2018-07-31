# Welcome to the SBCA Unified-File-Format Repository

# What is the SBCA Unified-File-Format?

The SBCA Unified-File-Format developed by [SBCA](https://www.sbcindustry.com/). It's purpose is to provide a standard data model for the interoperability of machinery and software that are involved in the building, designing, shipping and quality control of structural building components and their connecting hardware, as well as other related information in the structural building component industry. 

# What is a Data Standard?

From Wikipedia: "A standard data model or industry standard data model (ISDM) is a data model that is widely applied in some industry, and shared amongst competitors to some degree. They are often defined by standards bodies, database vendors or operating system vendors.

When in use, they enable easier and faster information sharing because heterogeneous organizations have a standard vocabulary and pre-negotiated semantics, format, and quality standards for exchanged data. The standardization affects software architecture as solutions that vary from the standard may cause data sharing issues and problems if data is out of compliance with the standard.

Effective standard models have been developed in the banking, insurance, pharmaceutical and automotive industries, to reflect the stringent standards applied to customer information gathering, customer privacy, consumer safety, or just in time manufacturing."

# Examples of other industries that have Data Standards:

* [IFC (Industry Foundation Classes)](http://www.buildingsmart-tech.org/specifications/ifc-overview)
* [ISO 10303](https://en.wikipedia.org/wiki/ISO_10303)
* [United States Geological Survey](https://www2.usgs.gov/datamanagement/plan/datastandards.php)

# What is in the SBCA Unified-File-Format?

The SBCA Unified-File-Format contains the following facts of a structural building components.

General Component Information

- Name/Label
- Component Type 
- Number of Plies
- File Format Version 
- File Creation Time ([ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601))
- File Creation Program
- Camber
- Part Information
   - Members
     - Name
     - Material
     - 3D Geometry
     - QC Information
  - Hardware
    - Name
    - Material
    - Location
  - Bearings
    - Name/Label
    - Location

And other information about the physical makeup of the component.

# Who maintains and develops the SBCA Unified-File-Format?

While SBCA manages and approves the changes and development of this standard, input and pull requests are welcome from any interested parties. If this is your first time using github, [here](https://www.youtube.com/watch?v=w3jLJU7DT5E) is a short explanation video. For more information on the process of pull requests check out [this tutorial](https://help.github.com/articles/about-pull-requests/)

To make a suggestion for changing the file format, start by taking a look at [the JSON Schema that describes the Component file](https://github.com/jth41/sbca-data-standard/blob/master/SBCA_DataStandard/Resources/Schema.json). JSON Schema is a  vocabulary that allows you to annotate and validate JSON documents. This allows humans and computers to understand what is in a file and whether or not a particular file adheres to a standard schema. For more information, checkout [http://json-schema.org/](http://json-schema.org/) and some of the [examples there](http://json-schema.org/examples.html).

By suggesting edits to the JSON Schema that identifies the valid schema for the SBCA Standard Component File, you express the changes you would like to see in the standard. We ask that you also update the included sample project with your suggestions as well. This let's new people see software in action using the file type. 

# Future Work

While not a part of this current standard, future work may be done on:
    -Component Layout
    -Component Loading Information
    -Part Cutting Information (eg. saw files)

# Example

A quick sample of what a Json data file for a Component looks like:

    {
      "Name": "Test",
      "Version": "0.1.1",
      "CreationProgram": "SBCA Uniform Data Standard Repository Tests",
      "CreationProgramVersion": "0.1.1",
      "CreationTimeStamp": "2018-06-15T00:00:00",
      "DistanceUnit": "Inches",
      "AngleUnit": "Degrees",
      "NumberOfPlies": 1,
      "PliesFieldInstalled": false,
      "ComponentUsages": [ "Roof" ],
      "MaterialTypes": [ "ConnectorPlate", "Lumber", "Hanger" ],
      "MaterialTypeCollections": [
        {
          "Name": "ConnectorPlateTypes",
          "MaterialType": "ConnectorPlate",
          "Materials": [
            {
              "MaterialType": "ConnectorPlate",
              "PlateType": "AS20",
              "PlateManufacturer": "Simpson Strong Tie",
              "Width": 4.0,
              "Length": 4.0,
              "Thickness": 0.0356,
              "PlateGauge": "Twenty",
              "Guid": "92862168-2b8c-42f6-9a68-68edaabebc29"
            }
          ]
        },
        {
          "Name": "Lumbers",
          "MaterialType": "Lumber",
          "Materials": [
            {
              "MaterialType": "Lumber",
              "NominalThickness": "2",
              "NominalWidth": "4",
              "ActualThickness": 1.5,
              "ActualWidth": 3.5,
              "Grade": "Number2",
              "Species": "SouthernPine",
              "TreatmentType": "None",
              "GradingMethod": "Visual",
              "Structure": "Sawn",
              "Guid": "9db95b90-542e-4045-ae39-42ce31ef65f8"
            }
          ]
        },
        {
          "Name": "Hangers",
          "MaterialType": "Hanger",
          "Materials": [
            {
              "MaterialType": "Hanger",
              "Description": "Hanger 1",
              "IntersectionExtents": null,
              "Guid": "2e6993b2-888a-40d9-b40d-468a836aaa13"
            }
          ]
        }
      ],
      "HardwareSets": [
        [
          {
            "Name": "1",
            "MaterialDescription": "AS20 4x4",
            "MaterialType": "ConnectorPlate",
            "MaterialGuid": "92862168-2b8c-42f6-9a68-68edaabebc29",
            "FieldInstalled": false,
            "Center": [ 60.0, 3.5, 1.5 ],
            "NormalDirection": [ 0.0, 0.0, 1.0 ],
            "Angle": 0.0
          },
          {
            "Name": "1",
            "MaterialDescription": "AS20 4x4",
            "MaterialType": "ConnectorPlate",
            "MaterialGuid": "92862168-2b8c-42f6-9a68-68edaabebc29",
            "FieldInstalled": false,
            "Center": [ 60.0, 3.5, 1.5 ],
            "NormalDirection": [ 0.0, 0.0, -1.0 ],
            "Angle": 0.0
          }
        ]
      ],
      "Members": [
        {
          "Name": "B1",
          "MemberTypes": [ "BottomChord" ],
          "MaterialDescription": "#2 SYP 2x4",
          "MaterialType": "Lumber",
          "MaterialGuid": "9db95b90-542e-4045-ae39-42ce31ef65f8",
          "FieldInstalled": false,
          "StockLength": 120.0,
          "Geometry": {
            "Vertices": [
              [ 96.0, 1.5, 0.0 ],
              [ 0.0, 1.5, 0.0 ],
              [ 0.0, 1.5, 0.25 ],
              [ 9.75, 1.5, 3.5 ],
              [ 96.0, 1.5, 3.5 ],
              [ 96.0, 0.0, 0.0 ],
              [ 0.0, 0.0, 0.0 ],
              [ 0.0, 0.0, 0.25 ],
              [ 9.75, 0.0, 3.5 ],
              [ 96.0, 0.0, 3.5 ]
            ],
            "Faces": [
              [ 0, 1, 2 ],
              [ 0, 2, 3 ],
              [ 0, 3, 4 ],
              [ 0, 5, 6 ],
              [ 0, 6, 15 ],
              [ 1, 6, 7 ],
              [ 1, 7, 2 ],
              [ 2, 7, 8 ],
              [ 2, 8, 3 ],
              [ 3, 8, 9 ],
              [ 3, 9, 4 ],
              [ 4, 9, 5 ],
              [ 4, 5, 0 ],
              [ 5, 9, 8 ],
              [ 5, 8, 7 ],
              [ 5, 7, 6 ]
            ]
          },
          "Orientation": [ 1.0, 0.0, 0.0 ]
        }
      ],
      "Bearings": [
        {
          "Guid": "c6423507-d96c-4fbb-97b9-c16a48ebff09",
          "Description": "Hanger",
          "AssociatedMaterialGuid": "2e6993b2-888a-40d9-b40d-468a836aaa13",
          "Width": 3.5,
          "Depth": 1.5,
          "Center": [ 1.75, 0.0, 0.75 ],
          "NormalDirection": [ 0.0, 1.0, 0.0 ],
          "AssociatedHardwareGuids": [ "2e6993b2-888a-40d9-b40d-468a836aaa13" ]
        },
        {
          "Guid": "2e6993b2-888a-40d9-b40d-468a836aaa13",
          "Description": "Double Wall Plate",
          "AssociatedMaterialGuid": "9db95b90-542e-4045-ae39-42ce31ef65f8",
          "Width": 3.5,
          "Depth": 1.5,
          "Center": [ 95.25, 0.0, 0.75 ],
          "NormalDirection": [ 0.0, 1.0, 0.0 ],
          "AssociatedHardwareGuids": []
        }
      ]
    }
