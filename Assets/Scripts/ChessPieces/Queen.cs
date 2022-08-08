using System;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        for (int y = currentY - 1; y >= 0; y--)
        {
            if (board[currentX, y] == null)
            {
                r.Add(new Vector2Int(currentX, y));
            }
            if (board[currentX, y] != null)
            {
                if (board[currentX, y].team != team)
                {
                    r.Add(new Vector2Int(currentX, y));
                }
                break;
            }
        }

        for (int x = currentX + 1; x < tileCountX; x++)
        {
            if (board[x, currentY] == null)
            {
                r.Add(new Vector2Int(x, currentY));
            }
            if (board[x, currentY] != null)
            {
                if (board[x, currentY].team != team)
                {
                    r.Add(new Vector2Int(x, currentY));
                }
                break;
            }
        }

        for (int y = currentY + 1; y < tileCountY; y++)
        {
            if (board[currentX, y] == null)
            {
                r.Add(new Vector2Int(currentX, y));
            }
            if (board[currentX, y] != null)
            {
                if (board[currentX, y].team != team)
                {
                    r.Add(new Vector2Int(currentX, y));
                }
                break;
            }
        }

        for (int x = currentX - 1; x >= 0; x--)
        {
            if (board[x, currentY] == null)
            {
                r.Add(new Vector2Int(x, currentY));
            }
            if (board[x, currentY] != null)
            {
                if (board[x, currentY].team != team)
                {
                    r.Add(new Vector2Int(x, currentY));
                }
                break;
            }
        }

        for (int x = currentX + 1, y = currentY + 1; x < tileCountX && y < tileCountY; x++, y++)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        for (int x = currentX - 1, y = currentY + 1; x >= 0 && y < tileCountY; x--, y++)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        for (int x = currentX + 1, y = currentY - 1; x < tileCountX && y >= 0; x++, y--)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        for (int x = currentX - 1, y = currentY - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (board[x, y] == null)
            {
                r.Add(new Vector2Int(x, y));
            }
            else
            {
                if (board[x, y].team != team)
                {
                    r.Add(new Vector2Int(x, y));
                }
                break;
            }
        }

        return r;
    }
}
