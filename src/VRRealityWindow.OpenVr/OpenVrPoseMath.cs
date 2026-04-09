using System.Numerics;
using Valve.VR;

namespace VRRealityWindow.OpenVr;

internal static class OpenVrPoseMath
{
    public static Vector3 GetTranslation(in HmdMatrix34_t matrix)
    {
        return new Vector3(matrix.m3, matrix.m7, matrix.m11);
    }

    public static Vector3 TransformDirection(in HmdMatrix34_t matrix, Vector3 direction)
    {
        return new Vector3(
            (matrix.m0 * direction.X) + (matrix.m1 * direction.Y) + (matrix.m2 * direction.Z),
            (matrix.m4 * direction.X) + (matrix.m5 * direction.Y) + (matrix.m6 * direction.Z),
            (matrix.m8 * direction.X) + (matrix.m9 * direction.Y) + (matrix.m10 * direction.Z));
    }

    public static HmdMatrix34_t CreateWorldLockedTransform(in HmdMatrix34_t hmdPose, float distanceMeters, float verticalOffsetMeters, float tiltDegrees)
    {
        var right = Vector3.Normalize(TransformDirection(hmdPose, Vector3.UnitX));
        var up = Vector3.Normalize(TransformDirection(hmdPose, Vector3.UnitY));
        var back = Vector3.Normalize(TransformDirection(hmdPose, Vector3.UnitZ));
        var forward = -back;
        var position = GetTranslation(hmdPose) + (forward * distanceMeters) + (up * verticalOffsetMeters);

        return CreateTransform(right, up, back, position, tiltDegrees);
    }

    public static HmdMatrix34_t CreateFallbackWorldTransform(float distanceMeters, float verticalOffsetMeters, float tiltDegrees)
    {
        var right = Vector3.UnitX;
        var up = Vector3.UnitY;
        var back = Vector3.UnitZ;
        var position = new Vector3(0f, verticalOffsetMeters, -distanceMeters);

        return CreateTransform(right, up, back, position, tiltDegrees);
    }

    public static HmdMatrix34_t CreateHandLockedTransform(bool leftHand, float distanceMeters, float verticalOffsetMeters, float lateralOffsetMeters, float tiltDegrees)
    {
        var right = Vector3.UnitX;
        var up = Vector3.UnitY;
        var back = Vector3.UnitZ;
        var lateral = leftHand ? lateralOffsetMeters : -lateralOffsetMeters;
        var position = new Vector3(lateral, verticalOffsetMeters, -distanceMeters);

        return CreateTransform(right, up, back, position, tiltDegrees);
    }

    public static HmdMatrix34_t Multiply(in HmdMatrix34_t parent, in HmdMatrix34_t child)
    {
        return new HmdMatrix34_t
        {
            m0 = (parent.m0 * child.m0) + (parent.m1 * child.m4) + (parent.m2 * child.m8),
            m1 = (parent.m0 * child.m1) + (parent.m1 * child.m5) + (parent.m2 * child.m9),
            m2 = (parent.m0 * child.m2) + (parent.m1 * child.m6) + (parent.m2 * child.m10),
            m3 = (parent.m0 * child.m3) + (parent.m1 * child.m7) + (parent.m2 * child.m11) + parent.m3,
            m4 = (parent.m4 * child.m0) + (parent.m5 * child.m4) + (parent.m6 * child.m8),
            m5 = (parent.m4 * child.m1) + (parent.m5 * child.m5) + (parent.m6 * child.m9),
            m6 = (parent.m4 * child.m2) + (parent.m5 * child.m6) + (parent.m6 * child.m10),
            m7 = (parent.m4 * child.m3) + (parent.m5 * child.m7) + (parent.m6 * child.m11) + parent.m7,
            m8 = (parent.m8 * child.m0) + (parent.m9 * child.m4) + (parent.m10 * child.m8),
            m9 = (parent.m8 * child.m1) + (parent.m9 * child.m5) + (parent.m10 * child.m9),
            m10 = (parent.m8 * child.m2) + (parent.m9 * child.m6) + (parent.m10 * child.m10),
            m11 = (parent.m8 * child.m3) + (parent.m9 * child.m7) + (parent.m10 * child.m11) + parent.m11,
        };
    }

    public static HmdMatrix34_t InvertRigid(in HmdMatrix34_t matrix)
    {
        return new HmdMatrix34_t
        {
            m0 = matrix.m0,
            m1 = matrix.m4,
            m2 = matrix.m8,
            m3 = -((matrix.m0 * matrix.m3) + (matrix.m4 * matrix.m7) + (matrix.m8 * matrix.m11)),
            m4 = matrix.m1,
            m5 = matrix.m5,
            m6 = matrix.m9,
            m7 = -((matrix.m1 * matrix.m3) + (matrix.m5 * matrix.m7) + (matrix.m9 * matrix.m11)),
            m8 = matrix.m2,
            m9 = matrix.m6,
            m10 = matrix.m10,
            m11 = -((matrix.m2 * matrix.m3) + (matrix.m6 * matrix.m7) + (matrix.m10 * matrix.m11)),
        };
    }

    private static HmdMatrix34_t CreateTransform(Vector3 right, Vector3 up, Vector3 back, Vector3 position, float tiltDegrees)
    {
        var tilt = Quaternion.CreateFromAxisAngle(right, DegreesToRadians(tiltDegrees));
        var tiltedUp = Vector3.Normalize(Vector3.Transform(up, tilt));
        var tiltedBack = Vector3.Normalize(Vector3.Transform(back, tilt));

        return new HmdMatrix34_t
        {
            m0 = right.X,
            m1 = tiltedUp.X,
            m2 = tiltedBack.X,
            m3 = position.X,
            m4 = right.Y,
            m5 = tiltedUp.Y,
            m6 = tiltedBack.Y,
            m7 = position.Y,
            m8 = right.Z,
            m9 = tiltedUp.Z,
            m10 = tiltedBack.Z,
            m11 = position.Z,
        };
    }

    private static float DegreesToRadians(float value) => value * (MathF.PI / 180f);
}
