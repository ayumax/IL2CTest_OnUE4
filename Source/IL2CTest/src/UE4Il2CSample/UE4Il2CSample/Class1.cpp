#include "Class1.h"
// [15-2] This is UE4Il2CSample native code translated by IL2C, do not edit.

#include <UE4Il2CSample.h>
#include <UE4Il2CSample_internal.h>

#include <mscorlib.h>

#ifdef __cplusplus
extern "C" {
#endif

//////////////////////////////////////////////////////////////////////////////////
// [9-1] Type: UE4Il2CSample.Class1

//////////////////////////////////////////////////////////////////////////////////
// [9-2] File scope prototypes:

//////////////////////////////////////////////////////////////////////////////////
// [9-4] Type: UE4Il2CSample.Class1

///////////////////////////////////////
// [3] UE4Il2CSample.Class1.Add(System.Int32,System.Int32)

//-------------------
// [3-2] Function body:

int32_t UE4Il2CSample_Class1_Add__System_Int32_System_Int32(int32_t a, int32_t b)
{
    //-------------------
    // [3-4] Evaluation stacks (!objref):

#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    int32_t stack0_0__;
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    int32_t stack1_0__;

    //-------------------
    // [3-6] IL body:

    /* IL_0000: ldarg.0  */
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    stack0_0__ = a;
    /* IL_0001: ldarg.1  */
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    stack1_0__ = b;
    /* IL_0002: add  */
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    stack0_0__ = stack0_0__ + stack1_0__;
    /* IL_0003: ret  */
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
    il2c_return_with_value(stack0_0__);
#line 7 "C:\\Users\\ayuma\\source\\repos\\IL2CTest\\UE4Il2CSample\\UE4Il2CSample\\Class1.cs"
}

///////////////////////////////////////
// [3] UE4Il2CSample.Class1..ctor()

//-------------------
// [3-7] Declare execution frame:

typedef struct UE4Il2CSample_Class1__ctor_EXECUTION_FRAME_DECL
{
    const IL2C_EXECUTION_FRAME* pNext__;
    const uint16_t objRefCount__;
    const uint16_t valueCount__;
    //-------------------- objref
    UE4Il2CSample_Class1* stack0_0__;
} UE4Il2CSample_Class1__ctor_EXECUTION_FRAME__;

//-------------------
// [3-2] Function body:

void UE4Il2CSample_Class1__ctor(UE4Il2CSample_Class1* this__)
{
    il2c_assert(this__ != NULL);

    //-------------------
    // [3-5] Setup execution frame:

    UE4Il2CSample_Class1__ctor_EXECUTION_FRAME__ frame__ =
        { NULL, 1 };
    il2c_link_execution_frame(&frame__);

    //-------------------
    // [3-6] IL body:

    /* IL_0000: ldarg.0  */
    frame__.stack0_0__ = this__;
    /* IL_0001: call System.Object..ctor() */
    System_Object__ctor((System_Object*)frame__.stack0_0__);
    /* IL_0006: nop  */
    /* IL_0007: ret  */
    il2c_return_unlink(&frame__);
}

//////////////////////
// [7] Runtime helpers:

// [7-10-1] VTable (Not defined, same as System.Object)

// [7-8] Runtime type information
IL2C_RUNTIME_TYPE_BEGIN(UE4Il2CSample_Class1, "UE4Il2CSample.Class1", IL2C_TYPE_REFERENCE, sizeof(UE4Il2CSample_Class1), System_Object, 0, 0)
IL2C_RUNTIME_TYPE_END();

#ifdef __cplusplus
}
#endif
