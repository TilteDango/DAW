<?php

namespace App\Models;

use Faker\Core\Number;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use PhpParser\Node\Expr\Cast\Bool_;
use Illuminate\Http\Request;


class Courses extends Model
{
    use HasFactory;
    protected $fillable = [
        'name',
        'price',
        'description',
        'suscriber'
    ];


    public function CreateCourse(Request $request){
        Courses::create($request->all());
    }
}
