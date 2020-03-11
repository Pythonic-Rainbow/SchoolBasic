Option Explicit On
Imports SchoolBasic.Recursion
Imports NUnit.Framework

Namespace NUnit_Test

    <TestFixture>
    Public Class RecursionExerciseTest
        Private exercise As Exercise

        <SetUp>
        Protected Sub SetUp()
            exercise = New Exercise
        End Sub

        <Test>
        Public Sub SumTo()
            Assert.AreEqual(exercise.SumTo(3), 6)
            Assert.AreEqual(exercise.SumTo(4), 10)
            Assert.AreEqual(exercise.SumTo(6), 21)
        End Sub

        <Test>
        Public Sub IsPalindrome()
            Assert.IsTrue(exercise.IsPalindrome("careerac"))
            Assert.IsFalse(exercise.IsPalindrome("Nope"))
        End Sub

        <Test>
        Public Sub PyramidCount()
            Assert.AreEqual(exercise.PyramidCount(6), 56)
            Assert.AreEqual(exercise.PyramidCount(12), 364)
        End Sub

    End Class

End Namespace