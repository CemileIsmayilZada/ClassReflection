using Entities.Models;
using Services.DTOs;

namespace Services.Mappers;

public static class Mapper
{
    public static R Map <T,R>(T value)
    {
        var responsetype=typeof(R);
        var entityType=value.GetType();

        var InstanceR=(R)Activator.CreateInstance(responsetype);

         var resArr=responsetype.GetProperties();
        var entArr=entityType.GetProperties();
        foreach(var propR in resArr)
        {
            foreach(var propT in entArr)
            {
                if (propR.Name == propT.Name)
                {
                    propR.SetValue(InstanceR, propT.GetValue(value));
                    //propR.SetValue(propT.GetValue(value), InstanceR);
                }
            }
        }
        //StatusResponseDto dt = new StatusResponseDto();
        //dt.Title = status.Title;
        //dt.Content = status.Content;
        //return dt;

        return InstanceR;
    }
}
