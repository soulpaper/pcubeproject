% M : the number of compressed samples
% N : the number of uncompressed samples
% A : the measurement matrix whose size is M by N
% K : the number of nonzero elements in uncompressed samples

function [x0]=sj_NNL(b,A,step_ratio,step_it_max,eps,lambda,max_it)

[M,N] = size(A);
I = eye(N,N); % (N x N) identity matrix 
ssss = pinv(A)*b;
kkkk = max(abs(ssss));
one = ones(N,1);
x0 = kkkk*ones(N,1); % Initial x
%x0 = x0/max(x0);
s  = kkkk*ones(N,1); % Initial s

it = 0; % iteration index
while 1 
    %evaluate the norm of the residuals
    X = diag(x0);
    S = diag(s);
    F_1 = -lambda * A' * ( b - A * x0 ) - s + one;
    F_2 = X*S*one;
    
    current_norm = norm([F_1 ; F_2]);    

    %Parameters Equation 1.11
    A_For_Linsolve = [ lambda * A' * A -I ; S X];
    B_For_Linsolve = [ -F_1 ; -F_2];
    
    %solve the following lienar system to obatin the step directions         
    solution = linsolve(A_For_Linsolve, B_For_Linsolve);
        
    delta_x      = solution(1:N);
    delta_s      = solution(N+1:2*N);    
        
    %Calcualte the step length
    %Generally, we just make steplength as a big number. 
    step_it = 0; % steplength ieration index
    step_length = 100; % Set a steplength value
    while 1
        tmp_x = x0 + delta_x * step_length;
        tmp_s = s  + delta_s * step_length;
              
        step_length = step_length * step_ratio;      
        step_it = step_it + 1;
        
        if step_it >= step_it_max            
            %disp('solution cannot be feasible');            
            x0 = tmp_x;
            x0(find(x0<=0.01)) = 0;
            return;
        end    
        
        % lamda must be in feasible. 
        if ( sum(tmp_s < 0 ) ) > 0 
            continue;
        end
        
        % tmp_t also must be in feasible.
        if sum(tmp_x < 0 ) > 0 
          continue;
        end
        tmp_F_1 = -lambda * A' * ( b - A * tmp_x ) - tmp_s  + one;
        tmp_F_2 = diag(tmp_x)*diag(tmp_s)*one;        
        tmp_norm = norm([tmp_F_1 ; tmp_F_2]);
      
        if tmp_norm > current_norm
            continue;
        end      
        break;
    end
    

    %update
    ttt = x0;
    x0      = tmp_x;
    s       = tmp_s;
    lambda  = lambda * 1.1;
          
    if it >= max_it || norm(b-A*x0).^2 <= eps
        break        
    end    
    it = it + 1;
end
% x0(find(x0<=0.01)) = 0;
x0(find(x0<=max(x0)*0.15)) = 0;
