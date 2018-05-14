# Welcome to the SBCA Unified-File-Format Repository

# What is the SBCA Unified-File-Format?

The SBCA Unified-File-Format developed by the [SBCA](https://www.sbcindustry.com/). It's purpose is to provide an standard data model for the interoperability of Machinery and Software that involved in the building, designing, shipping and quality control of Prefabricated Components and their connecting hardware, as well as other related information in the Prefabricated Component Industry. 

# What is a Data Standard?

From Wikipedia: "A standard data model or industry standard data model (ISDM) is a data model that is widely applied in some industry, and shared amongst competitors to some degree. They are often defined by standards bodies, database vendors or operating system vendors.

When in use, they enable easier and faster information sharing because heterogeneous organizations have a standard vocabulary and pre-negotiated semantics, format, and quality standards for exchanged data. The standardization affects software architecture as solutions that vary from the standard may cause data sharing issues and problems if data is out of compliance with the standard.

Effective standard models have been developed in the banking, insurance, pharmaceutical and automotive industries, to reflect the stringent standards applied to customer information gathering, customer privacy, consumer safety, or just in time manufacturing."

# Examples of other industries that have Data Standards:

* [IFC (Industry Foundation Classes)](http://www.buildingsmart-tech.org/specifications/ifc-overview)
* [ISO 10303](https://en.wikipedia.org/wiki/ISO_10303)
* [United States Geological Survey](https://www2.usgs.gov/datamanagement/plan/datastandards.php)

# What is in the SBCA Unified-File-Format?

The SBCA Unified-File-Format contains the following facts of a prefabricated component.

General Component Information

- Name/Label
- Component Type 
- Number of Plies
- File Format Version 
- File Creation Time (ISO 8601 format)
- File Creation Program Name
- File Creation Version
- Camber
- Part Information
   - Members
     - Name/Label
     - Material
     - 3D Geometry
     - QC Information
  - Connectors
    - Name/Label
    - Material
    - 3D Geometry
    - QC Information (Required Teeth Count, etc)
  - Hangers
    - Name/Label
    - Location
  - Bearings
    - Name/Label
    - Location
  - Bracing
    - Material
    - Location

And other information about the physical makeup of the component.

# Who maintains and develops the SBCA Unified-File-Format?

While the SBCA manages and approves the changes and development of this standard, input and pull requests are welcome from any interested parties. If this is your first time using github, [here](https://www.youtube.com/watch?v=w3jLJU7DT5E) is a short explanation video. For more information on the process of pull requests check out [this tutorial](https://help.github.com/articles/about-pull-requests/)

To make a suggestion for changing the file format, start by taking a look at [the JSON Schema that describes the Component file](https://github.com/jth41/sbca-data-standard/blob/master/SBCA_DataStandard/Resources/Schema.json). JSON Schema is a  vocabulary that allows you to annotate and validate JSON documents. This allows humans and computers to understand what is in a file and whether or not a particular file adheres to a standard schema. For more information, checkout [http://json-schema.org/](http://json-schema.org/) and some of the [examples there](http://json-schema.org/examples.html).

By suggesting edits to the JSON Schema that identifies the valid schema for the SBCA Standard Component File, you express the changes you would like to see in the standard. We ask that you also update the included sample project with your suggestions as well. This let's new people see software in action using the file type. 

# Future Work

While not a part of this current standard, future work may be done on:
    -Component Layout
    -Component Loading Information
    -Part Cutting Information (eg. saw files)

# Example

A quick sample of what a Json data file for a Component might look like:
(Note All Non-Nominal Units in Metric)

    {
      "Name": "T-1",
      "ComponentType": "RoofTruss",
      "NumberOfPlies": 1,
      "TopChordBracingLength": 24.0,
      "BottomChordBracingLength": 120.0,
      "Members": [
        {
          "Name": "B1",
          "Lumber": {
            "NominalThickness": "2",
            "NominalWidth": "4",
            "ActualThickness": 1.5,
            "ActualWidth": 3.5,
            "Length": 96.0,
            "Grade": "Number_2",
            "Species": "Spruce_Pine_Fir",
            "TreatmentType": "None",
            "GradingMethod": "VisuallyGraded",
            "Structure": "Sawn"
          },
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
              [ 0, 6, 1 ],
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
            ],
            "Surfaces": [
              [ 0, 1, 2 ],
              [ 3, 4 ],
              [ 5, 6 ],
              [ 7, 8 ],
              [ 9, 10 ],
              [ 11, 12 ],
              [ 13, 14, 15 ]
            ]
          },
          "MemberType": "BottomChord",
          "Length": 96.0,
          "Bracing": null,
          "Angle": 0.0,
          "Pitch": "0/12",
          "CrossSectionalArea": "5.25",
          "TransformationMatrix": [ 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.5, 1.0 ]
        },
       ...
      ],
      "PlatePairs": [
        {
          "Angle": 0.0,
          "Plate1TransformationMatrix": [ 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 5.875, 2.0, 1.5, 1.0 ],
          "Plate2TransformationMatrix": [ 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 5.875, 2.0, -0.0356, 1.0 ],
          "Name": "1",
          "Plate1Geometry": {
            "Vertices": [
              [ -2.5, -2.0, 0.0 ],
              [ -2.5, 2.0, 0.0 ],
              [ 2.5, 2.0, 0.0 ],
              [ 2.5, -2.0, 0.0 ],
              [ -2.5, -2.0, 0.0356 ],
              [ -2.5, 2.0, 0.0356 ],
              [ 2.5, 2.0, 0.0356 ],
              [ 2.5, -2.0, 0.0356 ]
            ],
            "Faces": [
              [ 0, 1, 2 ],
              [ 0, 2, 3 ],
              [ 0, 4, 5 ],
              [ 0, 5, 1 ],
              [ 1, 5, 6 ],
              [ 1, 6, 2 ],
              [ 2, 6, 7 ],
              [ 2, 7, 3 ],
              [ 3, 7, 4 ],
              [ 3, 4, 0 ],
              [ 4, 7, 6 ],
              [ 4, 6, 5 ]
            ],
            "Surfaces": [
              [ 0, 1 ],
              [ 2, 3 ],
              [ 4, 5 ],
              [ 6, 7 ],
              [ 8, 9 ],
              [ 10, 11 ]
            ]
          },
          "Plate2Geometry": {
            "Vertices": [
              [ -2.5, -2.0, 0.0 ],
              [ -2.5, 2.0, 0.0 ],
              [ 2.5, 2.0, 0.0 ],
              [ 2.5, -2.0, 0.0 ],
              [ -2.5, -2.0, 0.0356 ],
              [ -2.5, 2.0, 0.0356 ],
              [ 2.5, 2.0, 0.0356 ],
              [ 2.5, -2.0, 0.0356 ]
            ],
            "Faces": [
              [ 0, 1, 2 ],
              [ 0, 2, 3 ],
              [ 0, 4, 5 ],
              [ 0, 5, 1 ],
              [ 1, 5, 6 ],
              [ 1, 6, 2 ],
              [ 2, 6, 7 ],
              [ 2, 7, 3 ],
              [ 3, 7, 4 ],
              [ 3, 4, 0 ],
              [ 4, 7, 6 ],
              [ 4, 6, 5 ]
            ],
            "Surfaces": [
              [ 0, 1 ],
              [ 2, 3 ],
              [ 4, 5 ],
              [ 6, 7 ],
              [ 8, 9 ],
              [ 10, 11 ]
            ]
          },
          "CenterX": 5.875,
          "CenterY": 2.0,
          "CenterZ": 0.7322,
          "PlatePlacement": "Front_Back",
          "PlateType": "MT20",
          "PlateManufacturer": "MiTek",
          "Width": 4.0,
          "Length": 5.0,
          "Thickness": 0.0356,
          "BaseThickness": 0.0346
        },
      ...
      "Hangers": [
        {
          "Name": "Hanger 2",
          "Width": 3.5,
          "Depth": 1.5,
          "CenterPointX": 186.25,
          "CenterPointY": 0.0
        }
      ],
      "Bearings": [
        {
          "Name": "Bearing 1",
          "Width": 3.5,
          "Depth": 1.5,
          "BearingArea": 5.25,
          "CenterPointX": 1.75,
          "CenterPointY": 0.0,
          "Anchor": "Left",
          "BearingType": "Ledger"
        },
        {
          "Name": "Bearing 2",
          "Width": 3.5,
          "Depth": 1.5,
          "BearingArea": 5.25,
          "CenterPointX": 286.25,
          "CenterPointY": 0.0,
          "Anchor": "Right",
          "BearingType": "Ledger"
        }
      ]
    }
