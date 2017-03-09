using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace TwitterBattleTest
{
    class Animation
    {
        Texture2D m_texture; // アニメーションを含んだ画像
        Vector2 m_position; // 位置
        Point m_frameSize; // １コマの大きさ
        Point m_currentFrame; // 現在どのフレームかを表す
        Point m_sheetSize; // アニメーションが縦横何コマあるか
        float m_timer; // アニメーション用タイマー
        float m_updateInterval; // 何秒ごとに次のコマに進むか

        public Animation(Texture2D tex, Vector2 pos, Point frameSize, Point sheetSize, float updateInterval)
        {
            m_timer = 0.0f;
            m_texture = tex;
            m_position = pos;
            m_frameSize = frameSize;
            m_currentFrame = new Point(0, 0);
            m_sheetSize = sheetSize;
            m_updateInterval = updateInterval;
        }
    }
}
