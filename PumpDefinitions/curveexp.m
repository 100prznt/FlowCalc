function [qOpt,hOpt] = curveexp(q, h, order, n)
% CURVEOPT   Optimieren und erweitern der Kennlinienstützpunkte durch
% anlegen eines Polynoms.
% Weitere Informationen unter <a href="https://github.com/100prznt/FlowCalc/tree/master/PumpDefinitions">FlowCalc/PumpDefinitions</a>.
% Beispielaufruf: >> [Q_Opt, H_Opt] = curveopt(Q,H,3)
hold;
plot(q, h);

p = polyfit(q, h, order);

qOpt = linspace(min(q), max(q), n);
hOpt = polyval(p, qOpt);

plot(qOpt, hOpt);

end

