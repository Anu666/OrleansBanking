// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGen2f9f759387FeaturePopulator))]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"Grain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleansGeneratedCodeD0E97C0D
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof(global::Grain.Interfaces.States.AccountState))]
    internal sealed class OrleansCodeGenGrain_Interfaces_States_AccountStateSerializer
    {
        public OrleansCodeGenGrain_Interfaces_States_AccountStateSerializer(global::Orleans.Serialization.IFieldUtils fieldUtils)
        {
        }

        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::Grain.Interfaces.States.AccountState input = ((global::Grain.Interfaces.States.AccountState)original);
            global::Grain.Interfaces.States.AccountState result = new global::Grain.Interfaces.States.AccountState();
            context.RecordCopy(original, result);
            result.AccountBalance = input.AccountBalance;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::Grain.Interfaces.States.AccountState input = (global::Grain.Interfaces.States.AccountState)untypedInput;
            context.SerializeInner(input.AccountBalance, typeof(global::System.Double));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::Grain.Interfaces.States.AccountState result = new global::Grain.Interfaces.States.AccountState();
            context.RecordObject(result);
            result.AccountBalance = (global::System.Double)context.DeserializeInner(typeof(global::System.Double));
            return (global::Grain.Interfaces.States.AccountState)result;
        }
    }
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGen2f9f759387FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof(global::Grain.Account)));
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddSerializerType(typeof(global::Grain.Interfaces.States.AccountState), typeof(OrleansGeneratedCodeD0E97C0D.OrleansCodeGenGrain_Interfaces_States_AccountStateSerializer));
            feature.AddKnownType(@"Grain.Account,Grain", @"Grain.Account");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
