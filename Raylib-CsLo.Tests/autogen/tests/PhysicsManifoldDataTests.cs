//# raylib 4.0 bindings.   Lgpl Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace Raylib_CsLo.UnitTests
{
    /// <summary>Provides validation of the <see cref="PhysicsManifoldData" /> struct.</summary>
    public static unsafe partial class PhysicsManifoldDataTests
    {
        /// <summary>Validates that the <see cref="PhysicsManifoldData" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest()
        {
            Assert.Equal(sizeof(PhysicsManifoldData), Marshal.SizeOf<PhysicsManifoldData>());
        }

        /// <summary>Validates that the <see cref="PhysicsManifoldData" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest()
        {
            Assert.True(typeof(PhysicsManifoldData).IsLayoutSequential);
        }

        /// <summary>Validates that the <see cref="PhysicsManifoldData" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.Equal(72, sizeof(PhysicsManifoldData));
            }
            else
            {
                Assert.Equal(56, sizeof(PhysicsManifoldData));
            }
        }
    }
}