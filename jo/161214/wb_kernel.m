% function G=wb_kernel(FWHM,st,en,fc_stp,range)
function G=wb_kernel(FWHM,st,en,fc_stp,wv_stp)
% Function to genreate a Kernel matrix (Sparsifying Basis)

% FWHM = 20e-9;
% FWHM = 60e-9;

var=(FWHM/(2*sqrt(2*log(2))))^2; %For Gaussian

% x_mean = 350:5:1100;
% x_mean = 300+stp:stp:1300;

% x_mean = st+fc_stp*1e-9:fc_stp*1e-9:en;
x_mean = st:fc_stp*1e-9:en;
% x_mean = x_mean*1e-9;

% x = st+wv_stp*1e-9:wv_stp*1e-9:en;
x = st:wv_stp*1e-9:en;
% x = range*1e-9;
% x = st+5e-9:5e-9:en;
% x = x*1e-9;


for i = 1:length(x_mean)
    f=exp(-(1/(2*var))*(x-x_mean(i)).^2);
    G(:,i) = f';
end
% figure();
% plot(x,G(:,1));