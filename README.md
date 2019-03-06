# FlowCalc

Berechnung der Fördermenge von Pool-Pumpen in Abhängigkeit vom Systemdruck

## Installation
Das Programm erfordert keine Installation. Es kann nach dem kompilieren direkt gestartet werden, beziehungsweise kann eine im [Release-Feed](https://github.com/100prznt/FlowCalc/releases) veröffentlichte Version herunter geladen und gestartet werden.

## Bedienung
1. Über die Schaltfläche `Lade Pumpendefinition...` muss eine gültige Pumpen-Definitionsdatei geladen werden. Unter [PumpDefinitions](https://github.com/100prznt/FlowCalc/tree/master/PumpDefinitions) finden sich einige dieser Dateien. Siehe auch [Pumpendefinition](#pumpendefinition)
2. Eingabe des Systemdrucks, im Feld _Systemdruck [bar]_. Dies ist der Druck nach der Pumpe, beziehungsweise vor dem Filter, Eingabe hat in __bar__ zu erfolgen.
3. Die Berechnung der Fördermenge wird mit der Schaltfläche `Berechne Fördermenge` gestartet und direkt angezeigt.

## Screenshoot
![Screenshoot](docs/FlowCalc_Screen.png)

## Pumpendefinition
Das Programm benötigt zur Berechnung eine Pumpenkennlinie. Diese muss in Form einer Pumpen-Definitionsdatei angegeben werden. 

### Aufbau der Pumpen-Definitionsdatei
todo...

## Releases
Dieses Projekt wird auf der Continuous Integration Plattform [AppVeyor](https://www.appveyor.com/) kompiliert und im [Release-Feed](https://github.com/100prznt/FlowCalc/releases) veröffentlicht.

[![AppVeyor Build](https://img.shields.io/appveyor/ci/100prznt/FlowCalc.svg)](https://ci.appveyor.com/project/100prznt/FlowCalc)  
[![AppVeyor Tests](https://img.shields.io/appveyor/tests/100prznt/FlowCalc/master.svg)](https://ci.appveyor.com/project/100prznt/FlowCalc/build/tests)

[![GitHub Release](https://img.shields.io/github/release/100prznt/FlowCalc.svg)](https://github.com/100prznt/FlowCalc/releases/latest)  
[![GitHub (Pre-)Release](https://img.shields.io/github/release/100prznt/FlowCalc/all.svg)](https://github.com/100prznt/FlowCalc/releases) (Pre-)Release


## Contributing

Ich bin auf der Suche nach weiteren Entwicklern für dieses Projekt. Ideeen und Verbesserungen können aus einem Fork per Pull Request eingereicht werden.

[![GitHub Contributors](https://img.shields.io/github/contributors/100prznt/FlowCalc.svg)](https://github.com/100prznt/FlowCalc/graphs/contributors)


## Credits

* **Elias Ruemmler** - *Initial work* - [rmmlr](https://github.com/rmmlr)

Unter [Contributors](https://github.com/100prznt/FlowCalc/contributors) können weitere Projekt-Unterstützer eingesehen werden.


## Lizenz

Dieses Projekt (FlowCalcN) ist lizenziert unter der [MIT Lizenz](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form").  
Weitere Details unter [LICENSE.txt](https://github.com/100prznt/FlowCalc/blob/master/LICENSE.txt).

[![license](https://img.shields.io/github/license/100prznt/FlowCalc.svg)](https://github.com/100prznt/FlowCalc/blob/master/LICENSE.txt) 
