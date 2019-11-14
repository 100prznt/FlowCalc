function [p_delta] = CalcPressureDrop(di,l,k,Q)
%CALCPRESSUREDROP Calculate pressure drop in pipes
%   A turbulent flow is assumed and the medium is water at 25 °C
%
%   params:
%   di  inner diameter [mm]
%   l   length [m] 
%   k   roughness [mm]
%   Q   flow rate [m/s]

di = di/1000; % [m]
k = k/1000; % [m]
kv = 0.893 / 1E6; % [m^2/s] water @ 25 °C
rho = 997.05; % [kg/m^3] water @ 25 °C
q = Q / 3600; % [m^3/s]
a = pi * di^2 / 4; % [m^2]
v = q / a; % [m/s]
re = v * di / kv;


% Pipe friction coefficient (Lambda) according to Colebrook and White see: https://de.wikipedia.org/wiki/Rohrreibungszahl
% Iterative calculation
lambda = 0.005; % Start value for lambda
s = 0.001; % Step width for probing
i = 7; % Number of direction changes

error = realmax - 1;
lastError = realmax;
while i > 0
    lastError = error;
    error = 1 / sqrt(lambda) - (-2 * log10((2.51 / (re * sqrt(lambda))) + (k / (3.71 * di))));

    if abs(error) >= abs(lastError)
        s = s / -10;
        i = i - 1;
    end
    lambda = lambda + s;
end


% Pressure drop through pipe friction
% https://www.schweizer-fn.de/stroemung/druckverlust/druckverlust.php#druckverlustrohr
p_delta = lambda * l * rho * v^2 / (di * 2); % [Pa]

p_delta = p_delta / 1E2; % [mBar]
end

