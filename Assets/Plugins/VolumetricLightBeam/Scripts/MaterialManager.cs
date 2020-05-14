﻿using UnityEngine;
using System.Collections;

namespace VLB
{
    public static class MaterialManager
    {
        public static MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        public enum BlendingMode
        {
            Additive,
            SoftAdditive,
            TraditionalTransparency,
            Count
        }

        public enum Noise3D
        {
            Off,
            On,
            Count
        }

        public enum DepthBlend
        {
            Off,
            On,
            Count
        }

        public enum ColorGradient
        {
            Off,
            MatrixLow,
            MatrixHigh,
            Count
        }

        public enum ClippingPlane
        {
            Off,
            On,
            Count
        }

        static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor = new UnityEngine.Rendering.BlendMode[(int)BlendingMode.Count]
        {
            UnityEngine.Rendering.BlendMode.One,                // Additive
            UnityEngine.Rendering.BlendMode.OneMinusDstColor,   // SoftAdditive
            UnityEngine.Rendering.BlendMode.SrcAlpha,           // TraditionalTransparency
        };

        static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor = new UnityEngine.Rendering.BlendMode[(int)BlendingMode.Count]
        {
            UnityEngine.Rendering.BlendMode.One,                // Additive
            UnityEngine.Rendering.BlendMode.One,                // SoftAdditive
            UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha,   // TraditionalTransparency
        };

        static readonly bool[] BlendingMode_AlphaAsBlack = new bool[(int)BlendingMode.Count]
        {
            true,   // Additive
            true,   // SoftAdditive
            false,  // TraditionalTransparency
        };

        static int kStaticPropertiesCount = (int)BlendingMode.Count * (int)DepthBlend.Count * (int)ColorGradient.Count * (int)ClippingPlane.Count * (int)ClippingPlane.Count;

        public class StaticProperties
        {
            public BlendingMode blendingMode;
            public Noise3D noise3D;
            public DepthBlend depthBlend;
            public ColorGradient colorGradient;
            public ClippingPlane clippingPlane;

            public int materialID
            {
                get
                {
                    return (((((
                            (int)blendingMode) *
                            (int)Noise3D.Count + (int)noise3D) *
                            (int)DepthBlend.Count + (int)depthBlend) *
                            (int)ColorGradient.Count + (int)colorGradient) *
                            (int)ClippingPlane.Count + (int)clippingPlane)
                            ;
                }
            }

            public void ApplyToMaterial(Material mat)
            {
                mat.SetKeywordEnabled("VLB_ALPHA_AS_BLACK", BlendingMode_AlphaAsBlack[(int)blendingMode]);
                mat.SetInt("_BlendSrcFactor", (int)BlendingMode_SrcFactor[(int)blendingMode]);
                mat.SetInt("_BlendDstFactor", (int)BlendingMode_DstFactor[(int)blendingMode]);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_LOW", colorGradient == ColorGradient.MatrixLow);
                mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_HIGH", colorGradient == ColorGradient.MatrixHigh);
                mat.SetKeywordEnabled("VLB_DEPTH_BLEND", depthBlend == DepthBlend.On);
                mat.SetKeywordEnabled("VLB_NOISE_3D", noise3D == Noise3D.On);
                mat.SetKeywordEnabled("VLB_CLIPPING_PLANE", clippingPlane == ClippingPlane.On);
            }
        }

        public static Material NewMaterial(bool gpuInstanced)
        {
            var shader = Config.Instance.beamShader;
            if (!shader)
            {
                Debug.LogError("Invalid Beam Shader set in VLB Config");
                return null;
            }

            var material = new Material(shader);
            material.hideFlags = Consts.ProceduralObjectsHideFlags;
            material.renderQueue = Config.Instance.geometryRenderQueue;
            GpuInstancing.SetMaterialProperties(material, gpuInstanced);
            return material;
        }

        class MaterialsGroup
        {
            public Material[] materials = new Material[kStaticPropertiesCount];
        }

        static Hashtable ms_MaterialsGroup = new Hashtable(1);

        public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
        {
            MaterialsGroup group = (MaterialsGroup)ms_MaterialsGroup[groupID];
            if (group == null)
            {
                group = new MaterialsGroup();
                ms_MaterialsGroup[groupID] = group;
            }

            int matID = staticProps.materialID;
            Debug.Assert(matID < kStaticPropertiesCount);
            var mat = group.materials[matID];
            if (mat == null)
            {
                mat = NewMaterial(gpuInstanced:true);
                if(mat)
                {
                    group.materials[matID] = mat;
                    staticProps.ApplyToMaterial(mat);
                }
            }

            return mat;
        }
    }
}
