function p_delta = SampleCalc(q_arr, pipe_arr)
%SAMPLECALC Summary of this function goes here
%   Detailed explanation goes here

[c_pipe,i] = size(pipe_arr);
p_delta = zeros(c_pipe, length(q_arr));

for i_q = 1:length(q_arr)
    for p = 1:c_pipe
        p_delta(p, i_q) = CalcPressureDrop(pipe_arr(p,1),pipe_arr(p,2),pipe_arr(p,3),q_arr(i_q));
    end
end

mesh(p_delta);

end

