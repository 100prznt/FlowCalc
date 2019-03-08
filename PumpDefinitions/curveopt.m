function [qOpt,hOpt] = curveopt(q, h, order)
% CURVEOPT   Optimierung der Kennlinienstützpunkte durch
% anlegen eines Polynoms.
% Weitere Informationen unter <a href="https://github.com/100prznt/FlowCalc/tree/master/PumpDefinitions">FlowCalc/PumpDefinitions</a>.
% Beispielaufruf: >> [Qopt, Hopt] = curveopt(Q,H,3)
hold;
plot(q, h);

p = polyfit(q, h, order);

qOpt = linspace(min(q), max(q), 100);
hOpt = polyval(p, qOpt);

plot(qOpt, hOpt);

end

