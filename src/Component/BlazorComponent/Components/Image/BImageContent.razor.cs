﻿namespace BlazorComponent
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TImage"></typeparam>
    public partial class BImageContent<TImage> : ComponentAbstractBase<TImage> where TImage : IImage
    {
        public string Src => Component.Src;
        
        public string LazySrc => Component.LazySrc;
        
        public string Gradient => Component.Gradient;
    }
}