function hOpt = curveopt(q, h, order)
% CURVEOPT   Optimierung der Kennlinienstützpunkte durch
% anlegen eines Polynoms.
% Weitere Informationen unter <a href="https://github.com/100prznt/FlowCalc/tree/master/PumpDefinitions">FlowCalc/PumpDefinitions</a>.
hold;
plot(q, h);

p = polyfit(q, h, order);

hOpt = polyval(p, q);

plot(q, hOpt);

end

