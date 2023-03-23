<?php
namespace App\Models;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Http\Request;

class Team extends Model
{
    use HasFactory;
    protected $fillable = [
        'name',
        'price',
        'detail',
        'status'
    ];

    public function CreateTeam(Request $request){
        Team::create($request->all());
    }
}
