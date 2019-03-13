function z = calczeta(q,dp)
%UNTITLED Summary of this function goes here
%q: Volumenstrom in l/min
%dp: Delta P in bar


flowrate = (q * 0.06) / 3600; 
a = (pi * 40^2 / 4) / 1E6;

v = flowrate / a;

z = (2 * (dp / 0.00001)) / (999.7 * v^2);

end

