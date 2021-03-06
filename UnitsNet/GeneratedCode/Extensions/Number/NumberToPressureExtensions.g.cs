﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToPressure
{
    public static class NumberToPressureExtensions
    {
        #region Atmosphere

        /// <inheritdoc cref="Pressure.FromAtmospheres(UnitsNet.QuantityValue)" />
        public static Pressure Atmospheres<T>(this T value) => Pressure.FromAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromAtmospheres(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Atmospheres<T>(this T? value) where T : struct => Pressure.FromAtmospheres(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Bar

        /// <inheritdoc cref="Pressure.FromBars(UnitsNet.QuantityValue)" />
        public static Pressure Bars<T>(this T value) => Pressure.FromBars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromBars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Bars<T>(this T? value) where T : struct => Pressure.FromBars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Centibar

        /// <inheritdoc cref="Pressure.FromCentibars(UnitsNet.QuantityValue)" />
        public static Pressure Centibars<T>(this T value) => Pressure.FromCentibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromCentibars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Centibars<T>(this T? value) where T : struct => Pressure.FromCentibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decapascal

        /// <inheritdoc cref="Pressure.FromDecapascals(UnitsNet.QuantityValue)" />
        public static Pressure Decapascals<T>(this T value) => Pressure.FromDecapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecapascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Decapascals<T>(this T? value) where T : struct => Pressure.FromDecapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decibar

        /// <inheritdoc cref="Pressure.FromDecibars(UnitsNet.QuantityValue)" />
        public static Pressure Decibars<T>(this T value) => Pressure.FromDecibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecibars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Decibars<T>(this T? value) where T : struct => Pressure.FromDecibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DynePerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromDynesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure DynesPerSquareCentimeter<T>(this T value) => Pressure.FromDynesPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDynesPerSquareCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? DynesPerSquareCentimeter<T>(this T? value) where T : struct => Pressure.FromDynesPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region FootOfHead

        /// <inheritdoc cref="Pressure.FromFeetOfHead(UnitsNet.QuantityValue)" />
        public static Pressure FeetOfHead<T>(this T value) => Pressure.FromFeetOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromFeetOfHead(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? FeetOfHead<T>(this T? value) where T : struct => Pressure.FromFeetOfHead(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigapascal

        /// <inheritdoc cref="Pressure.FromGigapascals(UnitsNet.QuantityValue)" />
        public static Pressure Gigapascals<T>(this T value) => Pressure.FromGigapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromGigapascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Gigapascals<T>(this T? value) where T : struct => Pressure.FromGigapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hectopascal

        /// <inheritdoc cref="Pressure.FromHectopascals(UnitsNet.QuantityValue)" />
        public static Pressure Hectopascals<T>(this T value) => Pressure.FromHectopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromHectopascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Hectopascals<T>(this T? value) where T : struct => Pressure.FromHectopascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region InchOfMercury

        /// <inheritdoc cref="Pressure.FromInchesOfMercury(UnitsNet.QuantityValue)" />
        public static Pressure InchesOfMercury<T>(this T value) => Pressure.FromInchesOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromInchesOfMercury(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? InchesOfMercury<T>(this T? value) where T : struct => Pressure.FromInchesOfMercury(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilobar

        /// <inheritdoc cref="Pressure.FromKilobars(UnitsNet.QuantityValue)" />
        public static Pressure Kilobars<T>(this T value) => Pressure.FromKilobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilobars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Kilobars<T>(this T? value) where T : struct => Pressure.FromKilobars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareCentimeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilogramsForcePerSquareCentimeter<T>(this T? value) where T : struct => Pressure.FromKilogramsForcePerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareMeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilogramsForcePerSquareMeter<T>(this T? value) where T : struct => Pressure.FromKilogramsForcePerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMillimeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilogramsForcePerSquareMillimeter<T>(this T? value) where T : struct => Pressure.FromKilogramsForcePerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareCentimeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilonewtonsPerSquareCentimeter<T>(this T? value) where T : struct => Pressure.FromKilonewtonsPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareMeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilonewtonsPerSquareMeter<T>(this T? value) where T : struct => Pressure.FromKilonewtonsPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMillimeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilonewtonsPerSquareMillimeter<T>(this T? value) where T : struct => Pressure.FromKilonewtonsPerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilopascal

        /// <inheritdoc cref="Pressure.FromKilopascals(UnitsNet.QuantityValue)" />
        public static Pressure Kilopascals<T>(this T value) => Pressure.FromKilopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Kilopascals<T>(this T? value) where T : struct => Pressure.FromKilopascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerSquareFoot

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareFoot<T>(this T value) => Pressure.FromKilopoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilopoundsForcePerSquareFoot<T>(this T? value) where T : struct => Pressure.FromKilopoundsForcePerSquareFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerSquareInch

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareInch<T>(this T value) => Pressure.FromKilopoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? KilopoundsForcePerSquareInch<T>(this T? value) where T : struct => Pressure.FromKilopoundsForcePerSquareInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megabar

        /// <inheritdoc cref="Pressure.FromMegabars(UnitsNet.QuantityValue)" />
        public static Pressure Megabars<T>(this T value) => Pressure.FromMegabars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegabars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Megabars<T>(this T? value) where T : struct => Pressure.FromMegabars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeganewtonPerSquareMeter

        /// <inheritdoc cref="Pressure.FromMeganewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure MeganewtonsPerSquareMeter<T>(this T value) => Pressure.FromMeganewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMeganewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? MeganewtonsPerSquareMeter<T>(this T? value) where T : struct => Pressure.FromMeganewtonsPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megapascal

        /// <inheritdoc cref="Pressure.FromMegapascals(UnitsNet.QuantityValue)" />
        public static Pressure Megapascals<T>(this T value) => Pressure.FromMegapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegapascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Megapascals<T>(this T? value) where T : struct => Pressure.FromMegapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterOfHead

        /// <inheritdoc cref="Pressure.FromMetersOfHead(UnitsNet.QuantityValue)" />
        public static Pressure MetersOfHead<T>(this T value) => Pressure.FromMetersOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMetersOfHead(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? MetersOfHead<T>(this T? value) where T : struct => Pressure.FromMetersOfHead(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microbar

        /// <inheritdoc cref="Pressure.FromMicrobars(UnitsNet.QuantityValue)" />
        public static Pressure Microbars<T>(this T value) => Pressure.FromMicrobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicrobars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Microbars<T>(this T? value) where T : struct => Pressure.FromMicrobars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Micropascal

        /// <inheritdoc cref="Pressure.FromMicropascals(UnitsNet.QuantityValue)" />
        public static Pressure Micropascals<T>(this T value) => Pressure.FromMicropascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicropascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Micropascals<T>(this T? value) where T : struct => Pressure.FromMicropascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millibar

        /// <inheritdoc cref="Pressure.FromMillibars(UnitsNet.QuantityValue)" />
        public static Pressure Millibars<T>(this T value) => Pressure.FromMillibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillibars(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Millibars<T>(this T? value) where T : struct => Pressure.FromMillibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterOfMercury

        /// <inheritdoc cref="Pressure.FromMillimetersOfMercury(UnitsNet.QuantityValue)" />
        public static Pressure MillimetersOfMercury<T>(this T value) => Pressure.FromMillimetersOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillimetersOfMercury(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? MillimetersOfMercury<T>(this T? value) where T : struct => Pressure.FromMillimetersOfMercury(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millipascal

        /// <inheritdoc cref="Pressure.FromMillipascals(UnitsNet.QuantityValue)" />
        public static Pressure Millipascals<T>(this T value) => Pressure.FromMillipascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillipascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Millipascals<T>(this T? value) where T : struct => Pressure.FromMillipascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareCentimeter<T>(this T value) => Pressure.FromNewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? NewtonsPerSquareCentimeter<T>(this T? value) where T : struct => Pressure.FromNewtonsPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareMeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareMeter<T>(this T value) => Pressure.FromNewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? NewtonsPerSquareMeter<T>(this T? value) where T : struct => Pressure.FromNewtonsPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareMillimeter<T>(this T value) => Pressure.FromNewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? NewtonsPerSquareMillimeter<T>(this T? value) where T : struct => Pressure.FromNewtonsPerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Pascal

        /// <inheritdoc cref="Pressure.FromPascals(UnitsNet.QuantityValue)" />
        public static Pressure Pascals<T>(this T value) => Pressure.FromPascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPascals(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Pascals<T>(this T? value) where T : struct => Pressure.FromPascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerSquareFoot

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        public static Pressure PoundsForcePerSquareFoot<T>(this T value) => Pressure.FromPoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? PoundsForcePerSquareFoot<T>(this T? value) where T : struct => Pressure.FromPoundsForcePerSquareFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerSquareInch

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        public static Pressure PoundsForcePerSquareInch<T>(this T value) => Pressure.FromPoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? PoundsForcePerSquareInch<T>(this T? value) where T : struct => Pressure.FromPoundsForcePerSquareInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerInchSecondSquared

        /// <inheritdoc cref="Pressure.FromPoundsPerInchSecondSquared(UnitsNet.QuantityValue)" />
        public static Pressure PoundsPerInchSecondSquared<T>(this T value) => Pressure.FromPoundsPerInchSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsPerInchSecondSquared(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? PoundsPerInchSecondSquared<T>(this T? value) where T : struct => Pressure.FromPoundsPerInchSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Psi

        /// <inheritdoc cref="Pressure.FromPsi(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #215, please use PoundForcePerSquareInch instead")]
        public static Pressure Psi<T>(this T value) => Pressure.FromPsi(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPsi(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Psi<T>(this T? value) where T : struct => Pressure.FromPsi(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TechnicalAtmosphere

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(UnitsNet.QuantityValue)" />
        public static Pressure TechnicalAtmospheres<T>(this T value) => Pressure.FromTechnicalAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? TechnicalAtmospheres<T>(this T? value) where T : struct => Pressure.FromTechnicalAtmospheres(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareCentimeter<T>(this T value) => Pressure.FromTonnesForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? TonnesForcePerSquareCentimeter<T>(this T? value) where T : struct => Pressure.FromTonnesForcePerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareMeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareMeter<T>(this T value) => Pressure.FromTonnesForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? TonnesForcePerSquareMeter<T>(this T? value) where T : struct => Pressure.FromTonnesForcePerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareMillimeter<T>(this T value) => Pressure.FromTonnesForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? TonnesForcePerSquareMillimeter<T>(this T? value) where T : struct => Pressure.FromTonnesForcePerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Torr

        /// <inheritdoc cref="Pressure.FromTorrs(UnitsNet.QuantityValue)" />
        public static Pressure Torrs<T>(this T value) => Pressure.FromTorrs(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTorrs(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Pressure? Torrs<T>(this T? value) where T : struct => Pressure.FromTorrs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
