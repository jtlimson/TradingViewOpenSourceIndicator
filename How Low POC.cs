//This source code is subject to the terms of the Mozilla Public License 2.0 at https://mozilla.org/MPL/2.0/
//©aksharmty
//@version=4
study(title="High Low POC", shorttitle = "High Low POC", overlay=true ,resolution="")
n = input(title="Bar", defval=10, minval=10, maxval=80, type=input.integer)
highestHighs = highest(n)
lowestLows = lowest(n)
hld = (highestHighs-lowestLows)/n
plot(series=lowestLows,  title= "lowestLows", style=plot.style_circles, linewidth=3, color=color.red)
plot(series=highestHighs, title= "highestHighs", style=plot.style_circles, linewidth=3,  color=color.blue)
cp = n/2
poc = (hld*cp+lowestLows)
plot(series=poc, title= "POC", style=plot.style_circles, linewidth=3,  color=color.yellow)
len = input(20, minval=1, title="MA Period")
src = input(close, title="Source")
offset = input(title="Offset", type=input.integer, defval=0, minval=-500, maxval=500)
out = sma(src, len)
plot(out, title="SMA", color=color.green, offset=offset,linewidth=3)
