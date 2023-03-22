<?php

namespace App\Models;

use Faker\Core\Number;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use PhpParser\Node\Expr\Cast\Bool_;

class Courses extends Model
{
    use HasFactory;
    protected $fillable = [
        'name',
        'price',
        'description',
        'suscriber'
    ];


    public function CreateUser(String $name, Float $price, String $description, Bool $suscriber){
        Courses::create([
            'name' => $name,
            'price' => $price,
            'description' => $description,
            'suscriber' => $suscriber,
        ]);
    }
}
