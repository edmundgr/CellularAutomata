# Callular Automata

This project is a Windows desktop application to display 2D Cellular Automata

## Getting Started

Download and compile with Visual Studio. Run CAWinApp.

### Prerequisites

Requires .NET Framework 4.5

### Installing

Install CAWinApp and its dependencies in a folder and run CAWinApp.exe

## Running the tests

Unit tests are in the CellularAutomataEngineTest project. You can select Test -> Run -> All Tests in Visual Studio to run them.

## Deployment

See installing

## Built With

* [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework-runtime) - Microsoft .NET Framework

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

Currently this project is unversioned.

## Authors

* **Edmund Greaves** - *All Development* - [edmundgr](https://github.com/edmundgr)

## License

This project is licensed under the GNU General Public License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* Inspired by Stephen Wolfram

## Design

The projects are as follows:

* *CAViewControl* - Control to display the bitmap of the Cellular Automata
* *CAWinApp* - WinForms application to select and generate a Cellular Automata
* *CellularAutomataEngine* - Intializes and calculates rows of Cellular Automata based on a rule number.
* *CellularAutomataEngineTest* - Unit tests for CellularAutomataEngine project
