using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Generated;
using NUnit.Framework;
using System.Collections.Generic;
using Solver;
// <copyright file="ProblemaTest.Solve.g.cs" company="Avira Operations GmbH &amp; Co. KG;">Copyright © Avira Operations GmbH &amp; Co. KG; 2021</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Solver.Tests
{
    public partial class ProblemaTest
    {

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve77208()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[3];
    Interval s0 = new Interval(14, 528);
    intervals[0] = s0;
    Interval s1 = new Interval(14, 17);
    intervals[1] = s1;
    Interval s2 = new Interval(0, 1);
    intervals[2] = s2;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve77209()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[3];
    Interval s0 = new Interval(512, 513);
    intervals[0] = s0;
    Interval s1 = new Interval(0, 1);
    intervals[1] = s1;
    Interval s2 = new Interval(0, 1);
    intervals[2] = s2;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve772()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(0, 1);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException193()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(426, 832);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(539, 9, 1, list, list);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve77201()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(0, 1);
    intervals[0] = s0;
    Interval s1 = new Interval(0, 1);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve77202()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(0, 1);
    intervals[0] = s0;
    Interval s1 = new Interval(0, 3);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve413()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(512, 513);
    intervals[0] = s0;
    Interval s1 = new Interval(1, 5);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(1, interval.Start);
    PexAssert.AreEqual<int>(2, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve991()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(1022, 33281);
    intervals[0] = s0;
    Interval s1 = new Interval(1022, 32769);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(1022, interval.Start);
    PexAssert.AreEqual<int>(1023, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve77203()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(0, 1);
    intervals[0] = s0;
    Interval s1 = new Interval(1, 3);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(1, 1, 1, list, list);
    interval = this.Solve(problema);
    PexAssert.IsNotNull((object)interval);
    PexAssert.AreEqual<int>(0, interval.Start);
    PexAssert.AreEqual<int>(1, interval.Final);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException19302()
{
    List<Interval> list;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[2];
    Interval s0 = new Interval(0, 1);
    intervals[0] = s0;
    Interval s1 = new Interval(1, 2);
    intervals[1] = s1;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    problema = ProblemaFactory.Create(2, 1, 1, list, list);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException622()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(0, 4264);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[1];
    Interval s1 = new Interval(0, 168);
    intervals1[0] = s1;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(1423, 1, 16, list, list1);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException62201()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(269, 568);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[1];
    Interval s1 = new Interval(190, 552);
    intervals1[0] = s1;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(299, 1, 32, list, list1);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException19303()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(110, 200);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[1];
    Interval s1 = new Interval(495, 593);
    intervals1[0] = s1;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(10, 16, 1, list, list1);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve957()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(2097336, 541065496);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[1];
    Interval s1 = new Interval(2088767, 538968131);
    intervals1[0] = s1;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(536871174, 16, 1, list, list1);
    interval = this.Solve(problema);
    PexAssert.IsNull((object)interval);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
public void Solve95701()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(3538948, 37748753);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[1];
    Interval s1 = new Interval(4065344, 39846018);
    intervals1[0] = s1;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(34015627, 1, 1, list, list1);
    interval = this.Solve(problema);
    PexAssert.IsNull((object)interval);
    PexAssert.IsNotNull((object)problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException62202()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(451422285, 538455110);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[2];
    Interval s1 = new Interval(0, 1);
    intervals1[0] = s1;
    Interval s2 = new Interval(0, 1);
    intervals1[1] = s2;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(86623225, 18, 16, list, list1);
    interval = this.Solve(problema);
}

[Test]
[PexGeneratedBy(typeof(ProblemaTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SolveThrowsArgumentOutOfRangeException62203()
{
    List<Interval> list;
    List<Interval> list1;
    Problema problema;
    Interval interval;
    Interval[] intervals = new Interval[1];
    Interval s0 = new Interval(896, 898);
    intervals[0] = s0;
    list = new List<Interval>((IEnumerable<Interval>)intervals);
    Interval[] intervals1 = new Interval[3];
    Interval s1 = new Interval(771, 772);
    intervals1[0] = s1;
    Interval s2 = new Interval(802, 811);
    intervals1[1] = s2;
    Interval s3 = new Interval(771, 896);
    intervals1[2] = s3;
    list1 = new List<Interval>((IEnumerable<Interval>)intervals1);
    problema = ProblemaFactory.Create(2, 256, 32, list, list1);
    interval = this.Solve(problema);
}
    }
}
