﻿<%@ Page Language="C#" MasterPageFile="~/WebTestSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div> 
    <p style="display: inline-block">Каждый хороший верстальщик скажет, что только безукоризненное знание собственной работы способно принести позитивные результаты. Собственные наблюдения привели меня к выводу, что не только начинающие верстальщики не совсем понимают сути применения свойства float. На Хабре просмотрел имеющиеся публикации на данную тематику. Появилось желание поделиться некоторыми замечаниями и практическими применениями данного свойства. Приведенные ниже разъяснения в большинстве своем могут стать полезными для начинающего верстальщика.

Значения left, right определяют, по какой стороне будет выравниваться элемент;
элементы, имеющие значения left, right, становятся блочными (имея больший приоритет над значениями свойства display);
плавающий элемент обтекается следующим элементом (и другими вложенными в него элементами), следующими соседними элементами родителя, а также предыдущими соседними строчными элементами;
плавающий элемент занимает ширину контента за исключением, если внутренние элементы неплавающие (это было обсуждено в статье Float'омагия: пробуем не «плавать» в спецификации, чтобы не утонуть в потоке);
высота отца не зависит от высоты дочернего плавающего элемента, для следующих неплавающих элементов внешние отступы от плавающих элементов не будут действовать;
элемент, для которого предыдущий соседний элемент — плавающий, будет обтекать его, если позволит ширина отца, в противном случае — обтекать предыдущий плавающий ​​элемент;
элементы не будут флоатиться, если это не позволит ширина отца;
значения absolute и fixed свойства position отменяют действие свойства float.

    </div>
</asp:content>

