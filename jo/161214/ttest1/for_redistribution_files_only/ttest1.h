/*
 * MATLAB Compiler: 6.2 (R2016a)
 * Date: Tue Dec 13 17:38:59 2016
 * Arguments: "-B" "macro_default" "-W" "lib:ttest1" "-T" "link:lib" "-d"
 * "C:\jo\161208\ttest1\for_testing" "-v" "C:\jo\161208\ttest1.m" 
 */

#ifndef __ttest1_h
#define __ttest1_h 1

#if defined(__cplusplus) && !defined(mclmcrrt_h) && defined(__linux__)
#  pragma implementation "mclmcrrt.h"
#endif
#include "mclmcrrt.h"
#ifdef __cplusplus
extern "C" {
#endif

#if defined(__SUNPRO_CC)
/* Solaris shared libraries use __global, rather than mapfiles
 * to define the API exported from a shared library. __global is
 * only necessary when building the library -- files including
 * this header file to use the library do not need the __global
 * declaration; hence the EXPORTING_<library> logic.
 */

#ifdef EXPORTING_ttest1
#define PUBLIC_ttest1_C_API __global
#else
#define PUBLIC_ttest1_C_API /* No import statement needed. */
#endif

#define LIB_ttest1_C_API PUBLIC_ttest1_C_API

#elif defined(_HPUX_SOURCE)

#ifdef EXPORTING_ttest1
#define PUBLIC_ttest1_C_API __declspec(dllexport)
#else
#define PUBLIC_ttest1_C_API __declspec(dllimport)
#endif

#define LIB_ttest1_C_API PUBLIC_ttest1_C_API


#else

#define LIB_ttest1_C_API

#endif

/* This symbol is defined in shared libraries. Define it here
 * (to nothing) in case this isn't a shared library. 
 */
#ifndef LIB_ttest1_C_API 
#define LIB_ttest1_C_API /* No special import/export declaration */
#endif

extern LIB_ttest1_C_API 
bool MW_CALL_CONV ttest1InitializeWithHandlers(
       mclOutputHandlerFcn error_handler, 
       mclOutputHandlerFcn print_handler);

extern LIB_ttest1_C_API 
bool MW_CALL_CONV ttest1Initialize(void);

extern LIB_ttest1_C_API 
void MW_CALL_CONV ttest1Terminate(void);



extern LIB_ttest1_C_API 
void MW_CALL_CONV ttest1PrintStackTrace(void);

extern LIB_ttest1_C_API 
bool MW_CALL_CONV mlxTtest1(int nlhs, mxArray *plhs[], int nrhs, mxArray *prhs[]);



extern LIB_ttest1_C_API bool MW_CALL_CONV mlfTtest1(int nargout, mxArray** varargout, mxArray* varargin);

#ifdef __cplusplus
}
#endif
#endif
