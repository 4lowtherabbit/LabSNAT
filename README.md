# A lab for reproducing the SNAT exhausted issue.

Usage: /repro?url=http://...
Typically: ab -r -n 100000 -c 500 -s 120 https://labsnatxxxx.azurewebsites.net/repro/?url=https://labdelayxxxx.azurewebsites.net/delay?seconds=50

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)