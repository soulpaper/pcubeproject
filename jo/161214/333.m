function varargout = ttest1(varargin)
% TTEST1 MATLAB code for ttest1.fig
%      TTEST1, by itself, creates a new TTEST1 or raises the existing
%      singleton*.
%
%      H = TTEST1 returns the handle to a new TTEST1 or the handle to
%      the existing singleton*.
%
%      TTEST1('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in TTEST1.M with the given input arguments.
%
%      TTEST1('Property','Value',...) creates a new TTEST1 or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before ttest1_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to ttest1_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help ttest1

% Last Modified by GUIDE v2.5 01-Nov-2016 12:30:08

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @ttest1_OpeningFcn, ...
                   'gui_OutputFcn',  @ttest1_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before ttest1 is made visible.
function ttest1_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to ttest1 (see VARARGIN)

% Choose default command line output for ttest1
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes ttest1 wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = ttest1_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;
    fp = fopen('inputpath.txt');
    tline = fgetl(fp);
    while ischar(tline)
        load(tline);
        tline = fgetl(fp);
    end
    load Fmixli1027
    load OSAdatanm1025
    
    tmp_Y = bbb;
    tmp_F = tF';
    
    M = 400; ind = load('ind.txt');
    
    a = size(tmp_Y,1);
    stp = floor(a/M);
    Y = zeros(M, 501);
    F = zeros(M,521);
    for i = 1:M
       Y(i,:) = tmp_Y(stp*i+1,:);
       F(i,:) = tmp_F(stp*i+1,:);
    end    
    y = Y(:,ind);
    x = OSAdatanm(:,ind);
    
    range = 490:1:1010;
    F(F<0) = 0;
    F = F/max(max(F));
    
    st = 490e-9; en = 1010e-9;
    wv_stp = 1;fc_stp = 1; FWHM = 2e-9; 
    G1 = wb_kernel(FWHM,st,en,fc_stp,wv_stp);    
    G = G1;    
    
    A = F*G;
    
    step_ratio = 0.5; step_it_max = 20; eps = 1e-4; lambda=10; max_it = 20;
    tic
    est_s = sj_NNL(y,A,step_ratio,step_it_max,eps,lambda,max_it);
    toc
    est_x = G*est_s;   
    
    axes(handles.est_x)
    plot(range,est_x/max(est_x),'r');
    zoom on
    legend('DSP Recovery'); xlabel('wavelength (nm)'); ylabel('intensity');
    axis ([680 720 0 1.1]);


    
   
% --- Executes on button press in reset.
function reset_Callback(hObject, eventdata, handles)
% hObject    handle to reset (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
initialize_gui(gcbf, handles, true);

function initialize_gui(fig_handle, handles, isreset)
guidata(handles.figure1, handles);
