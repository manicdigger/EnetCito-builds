# Generated automatically with "cito". Do not edit.
use feature 'switch';
use integer;
use strict;

=head1 Enum ENetEventType

=head2 C<ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E()>

=head2 C<ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T()>

=head2 C<ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T()>

=head2 C<ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E()>

=cut

package ENetEventType;

sub E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E() { 0 }
sub E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T() { 1 }
sub E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T() { 2 }
sub E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E() { 3 }

=head1 Class Byte

=cut

package Byte;

=head2 C<$byte = Byte-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENet

=cut

package ENet;

=head2 C<ENet::E_N_E_T__B_U_F_F_E_R__M_A_X_I_M_U_M()>

=cut

sub E_N_E_T__B_U_F_F_E_R__M_A_X_I_M_U_M() { 65 }

=head2 C<ENet::E_N_E_T__H_O_S_T__A_N_Y()>

=cut

sub E_N_E_T__H_O_S_T__A_N_Y() { 0 }

=head2 C<ENet::E_N_E_T__H_O_S_T__B_A_N_D_W_I_D_T_H__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L()>

=cut

sub E_N_E_T__H_O_S_T__B_A_N_D_W_I_D_T_H__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L() { 1000 }

=head2 C<ENet::E_N_E_T__H_O_S_T__B_R_O_A_D_C_A_S_T()>

=cut

sub E_N_E_T__H_O_S_T__B_R_O_A_D_C_A_S_T() { -1 }

=head2 C<ENet::E_N_E_T__H_O_S_T__D_E_F_A_U_L_T__M_T_U()>

=cut

sub E_N_E_T__H_O_S_T__D_E_F_A_U_L_T__M_T_U() { 1400 }

=head2 C<ENet::E_N_E_T__H_O_S_T__R_E_C_E_I_V_E__B_U_F_F_E_R__S_I_Z_E()>

=cut

sub E_N_E_T__H_O_S_T__R_E_C_E_I_V_E__B_U_F_F_E_R__S_I_Z_E() { 262144 }

=head2 C<ENet::E_N_E_T__H_O_S_T__S_E_N_D__B_U_F_F_E_R__S_I_Z_E()>

=cut

sub E_N_E_T__H_O_S_T__S_E_N_D__B_U_F_F_E_R__S_I_Z_E() { 262144 }

=head2 C<ENet::E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__P_A_C_K_E_T__T_H_R_O_T_T_L_E()>

=cut

sub E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__P_A_C_K_E_T__T_H_R_O_T_T_L_E() { 32 }

=head2 C<ENet::E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__R_O_U_N_D__T_R_I_P__T_I_M_E()>

=cut

sub E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__R_O_U_N_D__T_R_I_P__T_I_M_E() { 500 }

=head2 C<ENet::E_N_E_T__P_E_E_R__F_R_E_E__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S()>

=cut

sub E_N_E_T__P_E_E_R__F_R_E_E__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S() { 8 }

=head2 C<ENet::E_N_E_T__P_E_E_R__F_R_E_E__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S()>

=cut

sub E_N_E_T__P_E_E_R__F_R_E_E__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S() { 32 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__I_N_T_E_R_V_A_L()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__I_N_T_E_R_V_A_L() { 10000 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__S_C_A_L_E()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__S_C_A_L_E() { 65536 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__A_C_C_E_L_E_R_A_T_I_O_N()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__A_C_C_E_L_E_R_A_T_I_O_N() { 2 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__C_O_U_N_T_E_R()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__C_O_U_N_T_E_R() { 7 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__D_E_C_E_L_E_R_A_T_I_O_N()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__D_E_C_E_L_E_R_A_T_I_O_N() { 2 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L() { 5000 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__S_C_A_L_E()>

=cut

sub E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__S_C_A_L_E() { 32 }

=head2 C<ENet::E_N_E_T__P_E_E_R__P_I_N_G__I_N_T_E_R_V_A_L()>

=cut

sub E_N_E_T__P_E_E_R__P_I_N_G__I_N_T_E_R_V_A_L() { 500 }

=head2 C<ENet::E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S()>

=cut

sub E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S() { 16 }

=head2 C<ENet::E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W__S_I_Z_E()>

=cut

sub E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W__S_I_Z_E() { 4096 }

=head2 C<ENet::E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__L_I_M_I_T()>

=cut

sub E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__L_I_M_I_T() { 32 }

=head2 C<ENet::E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_A_X_I_M_U_M()>

=cut

sub E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_A_X_I_M_U_M() { 30000 }

=head2 C<ENet::E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_I_N_I_M_U_M()>

=cut

sub E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_I_N_I_M_U_M() { 5000 }

=head2 C<ENet::E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S()>

=cut

sub E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S() { 64 }

=head2 C<ENet::E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W__S_I_Z_E()>

=cut

sub E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W__S_I_Z_E() { 1024 }

=head2 C<ENet::E_N_E_T__P_E_E_R__W_I_N_D_O_W__S_I_Z_E__S_C_A_L_E()>

=cut

sub E_N_E_T__P_E_E_R__W_I_N_D_O_W__S_I_Z_E__S_C_A_L_E() { 65536 }

=head2 C<ENet::E_N_E_T__P_O_R_T__A_N_Y()>

=cut

sub E_N_E_T__P_O_R_T__A_N_Y() { 0 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__A_C_K_N_O_W_L_E_D_G_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__A_C_K_N_O_W_L_E_D_G_E() { 1 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__B_A_N_D_W_I_D_T_H__L_I_M_I_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__B_A_N_D_W_I_D_T_H__L_I_M_I_T() { 10 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_N_N_E_C_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_N_N_E_C_T() { 2 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_U_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_U_N_T() { 13 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__D_I_S_C_O_N_N_E_C_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__D_I_S_C_O_N_N_E_C_T() { 4 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__A_C_K_N_O_W_L_E_D_G_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__A_C_K_N_O_W_L_E_D_G_E() { 128 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D() { 64 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__M_A_S_K()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__M_A_S_K() { 15 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__N_O_N_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__N_O_N_E() { 0 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__P_I_N_G()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__P_I_N_G() { 5 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__F_R_A_G_M_E_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__F_R_A_G_M_E_N_T() { 8 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__R_E_L_I_A_B_L_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__R_E_L_I_A_B_L_E() { 6 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E() { 7 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T() { 12 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_S_E_Q_U_E_N_C_E_D()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_S_E_Q_U_E_N_C_E_D() { 9 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__T_H_R_O_T_T_L_E__C_O_N_F_I_G_U_R_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__T_H_R_O_T_T_L_E__C_O_N_F_I_G_U_R_E() { 11 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__V_E_R_I_F_Y__C_O_N_N_E_C_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__V_E_R_I_F_Y__C_O_N_N_E_C_T() { 3 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__C_O_M_P_R_E_S_S_E_D()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__C_O_M_P_R_E_S_S_E_D() { 16384 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__M_A_S_K()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__M_A_S_K() { 49152 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__S_E_N_T__T_I_M_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__S_E_N_T__T_I_M_E() { 32768 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__M_A_S_K()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__M_A_S_K() { 12288 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__S_H_I_F_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__S_H_I_F_T() { 12 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T() { 255 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__F_R_A_G_M_E_N_T__C_O_U_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__F_R_A_G_M_E_N_T__C_O_U_N_T() { 1048576 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__M_T_U()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__M_T_U() { 4096 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__C_O_M_M_A_N_D_S()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__C_O_M_M_A_N_D_S() { 32 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__S_I_Z_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__S_I_Z_E() { 1073741824 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_E_E_R__I_D()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_E_E_R__I_D() { 4095 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__W_I_N_D_O_W__S_I_Z_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__W_I_N_D_O_W__S_I_Z_E() { 32768 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T() { 1 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__M_T_U()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__M_T_U() { 576 }

=head2 C<ENet::E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__W_I_N_D_O_W__S_I_Z_E()>

=cut

sub E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__W_I_N_D_O_W__S_I_Z_E() { 4096 }

=head2 C<ENet::E_N_E_T__S_O_C_K_E_T__W_A_I_T__I_N_T_E_R_R_U_P_T()>

=cut

sub E_N_E_T__S_O_C_K_E_T__W_A_I_T__I_N_T_E_R_R_U_P_T() { 4 }

=head2 C<ENet::E_N_E_T__S_O_C_K_E_T__W_A_I_T__N_O_N_E()>

=cut

sub E_N_E_T__S_O_C_K_E_T__W_A_I_T__N_O_N_E() { 0 }

=head2 C<ENet::E_N_E_T__S_O_C_K_E_T__W_A_I_T__R_E_C_E_I_V_E()>

=cut

sub E_N_E_T__S_O_C_K_E_T__W_A_I_T__R_E_C_E_I_V_E() { 2 }

=head2 C<ENet::E_N_E_T__S_O_C_K_E_T__W_A_I_T__S_E_N_D()>

=cut

sub E_N_E_T__S_O_C_K_E_T__W_A_I_T__S_E_N_D() { 1 }

=head2 C<ENet::E_N_E_T__V_E_R_S_I_O_N__M_A_J_O_R()>

=cut

sub E_N_E_T__V_E_R_S_I_O_N__M_A_J_O_R() { 1 }

=head2 C<ENet::E_N_E_T__V_E_R_S_I_O_N__M_I_N_O_R()>

=cut

sub E_N_E_T__V_E_R_S_I_O_N__M_I_N_O_R() { 3 }

=head2 C<ENet::E_N_E_T__V_E_R_S_I_O_N__P_A_T_C_H()>

=cut

sub E_N_E_T__V_E_R_S_I_O_N__P_A_T_C_H() { 8 }

=head2 C<ENet::S_O_C_K_E_T__E_R_R_O_R()>

=cut

sub S_O_C_K_E_T__E_R_R_O_R() { -1 }

=head2 C<$enet = ENet-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	$self->{dummy_command} = ENetIncomingCommand->new();
	$self->{command_sizes} = [];
	$self->{command_sizes}->[0] = 0;
	$self->{command_sizes}->[1] = 8;
	$self->{command_sizes}->[2] = 48;
	$self->{command_sizes}->[3] = 44;
	$self->{command_sizes}->[4] = 8;
	$self->{command_sizes}->[5] = 4;
	$self->{command_sizes}->[6] = 6;
	$self->{command_sizes}->[7] = 8;
	$self->{command_sizes}->[8] = 24;
	$self->{command_sizes}->[9] = 8;
	$self->{command_sizes}->[10] = 12;
	$self->{command_sizes}->[11] = 16;
	$self->{command_sizes}->[12] = 24;
	return $self;
}

sub deserialize($$) {
	my ($self, $a) = @_;
	my $h = ENetProtocolHeader->new();
	$h->{peer_i_d} = $self->read_short($a, 0);
	$h->{sent_time} = $self->read_short($a, 2);
	return $h;
}

sub deserialize_protocol_command_command($$$$$) {
	my ($self, $readBuf, $currentDataI, $commandNumber, $command) = @_;
	my $pos = $currentDataI + 4;
	given ($commandNumber) {
		when (1) {
			$command->{acknowledge} = ENetProtocolAcknowledge->new();
			$command->{acknowledge}->{received_reliable_sequence_number} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{acknowledge}->{received_sent_time} = $self->read_short($readBuf, $pos);
			$pos += 2;
		}
		when (2) {
			$command->{connect} = ENetProtocolConnect->new();
			$command->{connect}->{outgoing_peer_i_d} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{connect}->{incoming_session_i_d} = $self->read_byte($readBuf, $pos);
			$pos += 1;
			$command->{connect}->{outgoing_session_i_d} = $self->read_byte($readBuf, $pos);
			$pos += 1;
			$command->{connect}->{mtu} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{window_size} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{channel_count} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{incoming_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{outgoing_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{packet_throttle_interval} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{packet_throttle_acceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{packet_throttle_deceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{connect_i_d} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{connect}->{data} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (3) {
			$command->{verify_connect} = ENetProtocolVerifyConnect->new();
			$command->{verify_connect}->{outgoing_peer_i_d} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{verify_connect}->{incoming_session_i_d} = $self->read_byte($readBuf, $pos);
			$pos += 1;
			$command->{verify_connect}->{outgoing_session_i_d} = $self->read_byte($readBuf, $pos);
			$pos += 1;
			$command->{verify_connect}->{mtu} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{window_size} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{channel_count} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{incoming_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{outgoing_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{packet_throttle_interval} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{packet_throttle_acceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{packet_throttle_deceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{verify_connect}->{connect_i_d} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (4) {
			$command->{disconnect} = ENetProtocolDisconnect->new();
			$command->{disconnect}->{data} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (5) {
			$command->{ping} = ENetProtocolPing->new();
		}
		when (6) {
			$command->{send_reliable} = ENetProtocolSendReliable->new();
			$command->{send_reliable}->{data_length} = $self->read_short($readBuf, $pos);
			$pos += 2;
		}
		when (7) {
			$command->{send_unreliable} = ENetProtocolSendUnreliable->new();
			$command->{send_unreliable}->{unreliable_sequence_number} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_unreliable}->{data_length} = $self->read_short($readBuf, $pos);
			$pos += 2;
		}
		when (9) {
			$command->{send_unsequenced} = ENetProtocolSendUnsequenced->new();
			$command->{send_unsequenced}->{unsequenced_group} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_unsequenced}->{data_length} = $self->read_short($readBuf, $pos);
			$pos += 2;
		}
		when (8) {
			$command->{send_fragment} = ENetProtocolSendFragment->new();
			$command->{send_fragment}->{start_sequence_number} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_fragment}->{data_length} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_fragment}->{fragment_count} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{fragment_number} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{total_length} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{fragment_offset} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (10) {
			$command->{bandwidth_limit} = ENetProtocolBandwidthLimit->new();
			$command->{bandwidth_limit}->{incoming_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{bandwidth_limit}->{outgoing_bandwidth} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (11) {
			$command->{throttle_configure} = ENetProtocolThrottleConfigure->new();
			$command->{throttle_configure}->{packet_throttle_interval} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{throttle_configure}->{packet_throttle_acceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{throttle_configure}->{packet_throttle_deceleration} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
		when (12) {
			$command->{send_fragment} = ENetProtocolSendFragment->new();
			$command->{send_fragment}->{start_sequence_number} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_fragment}->{data_length} = $self->read_short($readBuf, $pos);
			$pos += 2;
			$command->{send_fragment}->{fragment_count} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{fragment_number} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{total_length} = $self->read_int($readBuf, $pos);
			$pos += 4;
			$command->{send_fragment}->{fragment_offset} = $self->read_int($readBuf, $pos);
			$pos += 4;
		}
	}
}

sub deserialize_protocol_command_header($$$) {
	my ($self, $currentData, $currentDataI) = @_;
	my $pos = $currentDataI;
	my $a = ENetProtocol->new();
	$a->{header} = ENetProtocolCommandHeader->new();
	$a->{header}->{command} = $self->read_byte($currentData, $pos);
	$pos += 1;
	$a->{header}->{channel_i_d} = $self->read_byte($currentData, $pos);
	$pos += 1;
	$a->{header}->{reliable_sequence_number} = $self->read_short($currentData, $pos);
	$pos += 2;
	return $a;
}

sub e_n_e_t__h_o_s_t__t_o__n_e_t_16($$) {
	my ($self, $a) = @_;
	return $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($a);
}

sub e_n_e_t__h_o_s_t__t_o__n_e_t_32($$) {
	my ($self, $a) = @_;
	return $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($a);
}

sub e_n_e_t__m_a_x($$$) {
	my ($self, $x, $y) = @_;
	return $x > $y ? $x : $y;
}

sub e_n_e_t__m_i_n($$$) {
	my ($self, $x, $y) = @_;
	return $x < $y ? $x : $y;
}

sub e_n_e_t__n_e_t__t_o__h_o_s_t_16($$) {
	my ($self, $a) = @_;
	return $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($a);
}

sub e_n_e_t__n_e_t__t_o__h_o_s_t_32($$) {
	my ($self, $a) = @_;
	return $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($a);
}

sub e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($$$) {
	my ($self, $a, $b) = @_;
	return $a - $b < 0 ? $b - $a : $a - $b;
}

sub e_n_e_t__t_i_m_e__g_r_e_a_t_e_r($$$) {
	my ($self, $a, $b) = @_;
	return $b - $a < 0;
}

sub e_n_e_t__t_i_m_e__g_r_e_a_t_e_r__e_q_u_a_l($$$) {
	my ($self, $a, $b) = @_;
	return !$self->e_n_e_t__t_i_m_e__l_e_s_s($a, $b);
}

sub e_n_e_t__t_i_m_e__l_e_s_s($$$) {
	my ($self, $a, $b) = @_;
	return $a - $b < 0;
}

sub e_n_e_t__t_i_m_e__l_e_s_s__e_q_u_a_l($$$) {
	my ($self, $a, $b) = @_;
	return !$self->e_n_e_t__t_i_m_e__g_r_e_a_t_e_r($a, $b);
}

=head2 C<ENet::e_n_e_t__v_e_r_s_i_o_n()>

=cut

sub e_n_e_t__v_e_r_s_i_o_n() {
	return ENet::e_n_e_t__v_e_r_s_i_o_n__c_r_e_a_t_e(1, 3, 8);
}

=head2 C<ENet::e_n_e_t__v_e_r_s_i_o_n__c_r_e_a_t_e($major, $minor, $patch)>

=cut

sub e_n_e_t__v_e_r_s_i_o_n__c_r_e_a_t_e($$$) {
	my ($major, $minor, $patch) = @_;
	return $major << 16 | $minor << 8 | $patch;
}

=head2 C<ENet::e_n_e_t__v_e_r_s_i_o_n__g_e_t__m_a_j_o_r($version)>

=cut

sub e_n_e_t__v_e_r_s_i_o_n__g_e_t__m_a_j_o_r($) {
	my ($version) = @_;
	return $version >> 16 & 255;
}

=head2 C<ENet::e_n_e_t__v_e_r_s_i_o_n__g_e_t__m_i_n_o_r($version)>

=cut

sub e_n_e_t__v_e_r_s_i_o_n__g_e_t__m_i_n_o_r($) {
	my ($version) = @_;
	return $version >> 8 & 255;
}

=head2 C<ENet::e_n_e_t__v_e_r_s_i_o_n__g_e_t__p_a_t_c_h($version)>

=cut

sub e_n_e_t__v_e_r_s_i_o_n__g_e_t__p_a_t_c_h($) {
	my ($version) = @_;
	return $version & 255;
}

sub read_byte($$$) {
	my ($self, $currentData, $currentDataI) = @_;
	return $currentData->[$currentDataI];
}

sub read_int($$$) {
	my ($self, $readBuf, $readPos) = @_;
	my $n = $readBuf->[$readPos + 3] << 24;
	$n |= $readBuf->[$readPos + 2] << 16;
	$n |= $readBuf->[$readPos + 1] << 8;
	$n |= $readBuf->[$readPos + 0];
	return $n;
}

sub read_short($$$) {
	my ($self, $readBuf, $readPos) = @_;
	my $n = $readBuf->[$readPos + 1] << 8;
	$n |= $readBuf->[$readPos + 0];
	$readPos += 2;
	return $self->{p}->int_to_ushort($n);
}

sub serialize_command($$$) {
	my ($self, $buf, $a) = @_;
	if (!defined($a)) {
		$a = ENetProtocol->new();
	}
	my $pos = [];
	$pos->[0] = 0;
	$self->write_byte($buf, $pos, $a->{header}->{command});
	$self->write_byte($buf, $pos, $a->{header}->{channel_i_d});
	$self->write_short($buf, $pos, $a->{header}->{reliable_sequence_number});
	given ($a->{header}->{command} & 15) {
		when (1) {
			$self->write_short($buf, $pos, $a->{acknowledge}->{received_reliable_sequence_number});
			$self->write_short($buf, $pos, $a->{acknowledge}->{received_sent_time});
			break;
		}
		when (2) {
			$self->write_short($buf, $pos, $a->{connect}->{outgoing_peer_i_d});
			$self->write_byte($buf, $pos, $a->{connect}->{incoming_session_i_d});
			$self->write_byte($buf, $pos, $a->{connect}->{outgoing_session_i_d});
			$self->write_int($buf, $pos, $a->{connect}->{mtu});
			$self->write_int($buf, $pos, $a->{connect}->{window_size});
			$self->write_int($buf, $pos, $a->{connect}->{channel_count});
			$self->write_int($buf, $pos, $a->{connect}->{incoming_bandwidth});
			$self->write_int($buf, $pos, $a->{connect}->{outgoing_bandwidth});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_interval});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_acceleration});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_deceleration});
			$self->write_int($buf, $pos, $a->{connect}->{connect_i_d});
			$self->write_int($buf, $pos, $a->{connect}->{data});
			break;
		}
		when (3) {
			$self->write_int($buf, $pos, $a->{connect}->{outgoing_peer_i_d});
			$self->write_byte($buf, $pos, $a->{connect}->{incoming_session_i_d});
			$self->write_byte($buf, $pos, $a->{connect}->{outgoing_session_i_d});
			$self->write_int($buf, $pos, $a->{connect}->{mtu});
			$self->write_int($buf, $pos, $a->{connect}->{window_size});
			$self->write_int($buf, $pos, $a->{connect}->{channel_count});
			$self->write_int($buf, $pos, $a->{connect}->{incoming_bandwidth});
			$self->write_int($buf, $pos, $a->{connect}->{outgoing_bandwidth});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_interval});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_acceleration});
			$self->write_int($buf, $pos, $a->{connect}->{packet_throttle_deceleration});
			$self->write_int($buf, $pos, $a->{connect}->{connect_i_d});
			break;
		}
		when (4) {
			$self->write_int($buf, $pos, $a->{disconnect}->{data});
			break;
		}
		when (5) {
			break;
		}
		when (6) {
			$self->write_short($buf, $pos, $a->{send_reliable}->{data_length});
			break;
		}
		when (7) {
			$self->write_short($buf, $pos, $a->{send_unreliable}->{unreliable_sequence_number});
			$self->write_short($buf, $pos, $a->{send_unreliable}->{data_length});
			break;
		}
		when ([ 8, 12 ]) {
			$self->write_short($buf, $pos, $a->{send_fragment}->{start_sequence_number});
			$self->write_short($buf, $pos, $a->{send_fragment}->{data_length});
			$self->write_int($buf, $pos, $a->{send_fragment}->{fragment_count});
			$self->write_int($buf, $pos, $a->{send_fragment}->{fragment_number});
			$self->write_int($buf, $pos, $a->{send_fragment}->{total_length});
			$self->write_int($buf, $pos, $a->{send_fragment}->{fragment_offset});
			break;
		}
		when (9) {
			$self->write_short($buf, $pos, $a->{send_unsequenced}->{unsequenced_group});
			$self->write_short($buf, $pos, $a->{send_unsequenced}->{data_length});
			break;
		}
		when (10) {
			$self->write_int($buf, $pos, $a->{bandwidth_limit}->{incoming_bandwidth});
			$self->write_int($buf, $pos, $a->{bandwidth_limit}->{outgoing_bandwidth});
			break;
		}
		when (11) {
			$self->write_int($buf, $pos, $a->{throttle_configure}->{packet_throttle_interval});
			$self->write_int($buf, $pos, $a->{throttle_configure}->{packet_throttle_acceleration});
			$self->write_int($buf, $pos, $a->{throttle_configure}->{packet_throttle_deceleration});
			break;
		}
	}
}

sub serialize_header($$$) {
	my ($self, $headerData, $header) = @_;
	my $pos = [];
	$pos->[0] = 0;
	$self->write_short($headerData, $pos, $header->{peer_i_d});
	$self->write_short($headerData, $pos, $header->{sent_time});
}

=head2 C<$enet-E<gt>set_platform($value)>

=cut

sub set_platform($$) {
	my ($self, $value) = @_;
	$self->{p} = $value;
}

=head2 C<ENet::to_byte($a)>

=cut

sub to_byte($) {
	my ($a) = @_;
	return $a & 0xff;
}

sub to_uint16($$) {
	my ($self, $a) = @_;
	return $self->{p}->int_to_ushort($a);
}

sub write_byte($$$$) {
	my ($self, $data, $pos, $value) = @_;
	my $pos_ = $pos->[0];
	$data->[$pos_] = ENet::to_byte($value);
	$pos->[0] += 1;
}

sub write_int($$$$) {
	my ($self, $data, $pos, $n) = @_;
	my $pos_ = $pos->[0];
	$data->[$pos_ + 3] = ENet::to_byte($n >> 24 & 255);
	$data->[$pos_ + 2] = ENet::to_byte($n >> 16 & 255);
	$data->[$pos_ + 1] = ENet::to_byte($n >> 8 & 255);
	$data->[$pos_ + 0] = ENet::to_byte($n & 255);
	$pos->[0] += 4;
}

sub write_short($$$$) {
	my ($self, $data, $pos, $value) = @_;
	my $pos_ = $pos->[0];
	$data->[$pos_] = ENet::to_byte($value & 255);
	$data->[$pos_ + 1] = ENet::to_byte($value >> 8 & 255);
	$pos->[0] += 2;
}

sub command_error($$) {
	my ($self, $event_) = @_;
	if (defined($event_) && $event_->{type} != ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E()) {
		return 1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_address_set_host($address, $hostName)>

=cut

sub enet_address_set_host($$$) {
	my ($self, $address, $hostName) = @_;
	return $self->{p}->enet_address_set_host($address, $hostName);
}

=head2 C<$enet-E<gt>enet_crc32(\@buffers, $bufferCount)>

=cut

sub enet_crc32($$$) {
	my ($self, $buffers, $bufferCount) = @_;
	my $crc = -1;
	if (!$self->{initialized_c_r_c32}) {
		$self->initialize_crc32();
	}
	for (my $buf = 0; $buf < $bufferCount; $buf++) {
		my $data = $buffers->[$buf]->{data};
		my $dataLength = $buffers->[$buf]->{data_length};
		for (my $i = 0; $i < $dataLength; $i++) {
			$crc = $crc >> 8 ^ $self->{crc_table}->[$crc & 255 ^ $data->[$i]];
		}
	}
	return $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32(~$crc);
}

=head2 C<$enet-E<gt>enet_deinitialize()>

=cut

sub enet_deinitialize($) {
	my ($self) = @_;
}

=head2 C<$enet-E<gt>enet_host_bandwidth_limit($host, $incomingBandwidth, $outgoingBandwidth)>

Adjusts the bandwidth limits of a host.

Parameters:

=over

=item $host

host to adjust

=item $incomingBandwidth

new incoming bandwidth

=item $outgoingBandwidth

new outgoing bandwidth

=back

=cut

sub enet_host_bandwidth_limit($$$$) {
	my ($self, $host, $incomingBandwidth, $outgoingBandwidth) = @_;
	$host->{incoming_bandwidth} = $incomingBandwidth;
	$host->{outgoing_bandwidth} = $outgoingBandwidth;
	$host->{recalculate_bandwidth_limits} = 1;
}

sub enet_host_bandwidth_throttle($$) {
	my ($self, $host) = @_;
	my $timeCurrent = $self->{p}->enet_time_get();
	my $elapsedTime = $timeCurrent - $host->{bandwidth_throttle_epoch};
	my $peersRemaining = $host->{connected_peers};
	my $dataTotal = ~0;
	my $bandwidth = ~0;
	my $throttle = 0;
	my $bandwidthLimit = 0;
	my $needsAdjustment = $host->{bandwidth_limited_peers} > 0 ? 1 : 0;
	my $peer;
	my $command = ENetProtocol->new();
	if ($elapsedTime < 1000) {
		return;
	}
	$host->{bandwidth_throttle_epoch} = $timeCurrent;
	if ($peersRemaining == 0) {
		return;
	}
	if ($host->{outgoing_bandwidth} != 0) {
		$dataTotal = 0;
		$bandwidth = $host->{outgoing_bandwidth} * $elapsedTime / 1000;
		for (my $i = 0; $i < $host->{peer_count}; $i++) {
			$peer = $host->{peers}->[$i];
			if ($peer->{state} != 5 && $peer->{state} != 6) {
				next;
			}
			$dataTotal += $peer->{outgoing_data_total};
		}
	}
	while ($peersRemaining > 0 && $needsAdjustment != 0) {
		$needsAdjustment = 0;
		if ($dataTotal <= $bandwidth) {
			$throttle = 32;
		}
		else {
			$throttle = $bandwidth * 32 / $dataTotal;
		}
		for (my $i = 0; $i < $host->{peer_count}; $i++) {
			$peer = $host->{peers}->[$i];
			my $peerBandwidth;
			if ($peer->{state} != 5 && $peer->{state} != 6 || $peer->{incoming_bandwidth} == 0 || $peer->{outgoing_bandwidth_throttle_epoch} == $timeCurrent) {
				next;
			}
			$peerBandwidth = $peer->{incoming_bandwidth} * $elapsedTime / 1000;
			if ($throttle * $peer->{outgoing_data_total} / 32 <= $peerBandwidth) {
				next;
			}
			$peer->{packet_throttle_limit} = $peerBandwidth * 32 / $peer->{outgoing_data_total};
			if ($peer->{packet_throttle_limit} == 0) {
				$peer->{packet_throttle_limit} = 1;
			}
			if ($peer->{packet_throttle} > $peer->{packet_throttle_limit}) {
				$peer->{packet_throttle} = $peer->{packet_throttle_limit};
			}
			$peer->{outgoing_bandwidth_throttle_epoch} = $timeCurrent;
			$peer->{incoming_data_total} = 0;
			$peer->{outgoing_data_total} = 0;
			$needsAdjustment = 1;
			$peersRemaining--;
			$bandwidth -= $peerBandwidth;
			$dataTotal -= $peerBandwidth;
		}
	}
	if ($peersRemaining > 0) {
		if ($dataTotal <= $bandwidth) {
			$throttle = 32;
		}
		else {
			$throttle = $bandwidth * 32 / $dataTotal;
		}
		for (my $i = 0; $i < $host->{peer_count}; $i++) {
			$peer = $host->{peers}->[$i];
			if ($peer->{state} != 5 && $peer->{state} != 6 || $peer->{outgoing_bandwidth_throttle_epoch} == $timeCurrent) {
				next;
			}
			$peer->{packet_throttle_limit} = $throttle;
			if ($peer->{packet_throttle} > $peer->{packet_throttle_limit}) {
				$peer->{packet_throttle} = $peer->{packet_throttle_limit};
			}
			$peer->{incoming_data_total} = 0;
			$peer->{outgoing_data_total} = 0;
		}
	}
	if ($host->{recalculate_bandwidth_limits} != 0) {
		$host->{recalculate_bandwidth_limits} = 0;
		$peersRemaining = $host->{connected_peers};
		$bandwidth = $host->{incoming_bandwidth};
		$needsAdjustment = 1;
		if ($bandwidth == 0) {
			$bandwidthLimit = 0;
		}
		else {
			while ($peersRemaining > 0 && $needsAdjustment != 0) {
				$needsAdjustment = 0;
				$bandwidthLimit = $bandwidth / $peersRemaining;
				for (my $i = 0; $i < $host->{peer_count}; $i++) {
					$peer = $host->{peers}->[$i];
					if ($peer->{state} != 5 && $peer->{state} != 6 || $peer->{incoming_bandwidth_throttle_epoch} == $timeCurrent) {
						next;
					}
					if ($peer->{outgoing_bandwidth} > 0 && $peer->{outgoing_bandwidth} >= $bandwidthLimit) {
						next;
					}
					$peer->{incoming_bandwidth_throttle_epoch} = $timeCurrent;
					$needsAdjustment = 1;
					$peersRemaining--;
					$bandwidth -= $peer->{outgoing_bandwidth};
				}
			}
		}
		for (my $i = 0; $i < $host->{peer_count}; $i++) {
			$peer = $host->{peers}->[$i];
			if ($peer->{state} != 5 && $peer->{state} != 6) {
				next;
			}
			$command->{header}->{command} = 138;
			$command->{header}->{channel_i_d} = 255;
			$command->{bandwidth_limit} = ENetProtocolBandwidthLimit->new();
			$command->{bandwidth_limit}->{outgoing_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($host->{outgoing_bandwidth});
			if ($peer->{incoming_bandwidth_throttle_epoch} == $timeCurrent) {
				$command->{bandwidth_limit}->{incoming_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($peer->{outgoing_bandwidth});
			}
			else {
				$command->{bandwidth_limit}->{incoming_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($bandwidthLimit);
			}
			$self->enet_peer_queue_outgoing_command($peer, $command, undef, 0, 0);
		}
	}
}

=head2 C<$enet-E<gt>enet_host_broadcast($host, $channelID, $packet)>

Queues a packet to be sent to all peers associated with the host.

Parameters:

=over

=item $host

host on which to broadcast the packet

=item $channelID

channel on which to broadcast

=item $packet

packet to broadcast

=back

=cut

sub enet_host_broadcast($$$$) {
	my ($self, $host, $channelID, $packet) = @_;
	my $currentPeer;
	for (my $i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		if ($currentPeer->{state} != 5) {
			next;
		}
		$self->enet_peer_send($currentPeer, $channelID, $packet);
	}
	if ($packet->{reference_count} == 0) {
		$self->enet_packet_destroy($packet);
	}
}

=head2 C<$enet-E<gt>enet_host_channel_limit($host, $channelLimit)>

Limits the maximum allowed channels of future incoming connections.

Parameters:

=over

=item $host

host to limit

=item $channelLimit

the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT

=back

=cut

sub enet_host_channel_limit($$$) {
	my ($self, $host, $channelLimit) = @_;
	if ($channelLimit == 0 || $channelLimit > 255) {
		$channelLimit = 255;
	}
	elsif ($channelLimit < 1) {
		$channelLimit = 1;
	}
	$host->{channel_limit} = $channelLimit;
}

=head2 C<$enet-E<gt>enet_host_check_events($host, $event_)>

Checks for any queued events on the host and dispatches one if available.

Parameters:

=over

=item $host

host to check for events

=item $event_

an event structure where event details will be placed if available

=back

=cut

sub enet_host_check_events($$$) {
	my ($self, $host, $event_) = @_;
	if (!defined($event_)) {
		return -1;
	}
	$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E();
	$event_->{peer} = undef;
	$event_->{packet} = undef;
	return $self->enet_protocol_dispatch_incoming_commands($host, $event_);
}

=head2 C<$enet-E<gt>enet_host_compress($host, $compressor)>

Sets the packet compressor the host should use to compress and decompress packets.

Parameters:

=over

=item $host

host to enable or disable compression for

=item $compressor

callbacks for for the packet compressor; if NULL, then compression is disabled

=back

=cut

sub enet_host_compress($$$) {
	my ($self, $host, $compressor) = @_;
	if (defined($host->{compressor})) {
		$host->{compressor}->destroy();
	}
	if (defined($compressor)) {
		$host->{compressor} = $compressor;
	}
	else {
		$host->{compressor} = undef;
	}
}

=head2 C<$enet-E<gt>enet_host_compress_with_range_coder($host)>

Sets the packet compressor the host should use to the default range coder.

Parameters:

=over

=item $host

@param host host to enable the range coder for

=back

=cut

sub enet_host_compress_with_range_coder($$) {
	my ($self, $host) = @_;
	return 0;
}

=head2 C<$enet-E<gt>enet_host_connect($host, $address, $channelCount, $data)>

Initiates a connection to a foreign host.

Parameters:

=over

=item $host

host seeking the connection

=item $address

destination for the connection

=item $channelCount

number of channels to allocate

=item $data

user data supplied to the receiving host 

=back

=cut

sub enet_host_connect($$$$$) {
	my ($self, $host, $address, $channelCount, $data) = @_;
	my $currentPeer = undef;
	my $channel;
	my $command = ENetProtocol->new();
	if ($channelCount < 1) {
		$channelCount = 1;
	}
	elsif ($channelCount > 255) {
		$channelCount = 255;
	}
	for (my $i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		if ($currentPeer->{state} == 0) {
			last;
		}
	}
	if ($host->{peer_count} == 0) {
		return undef;
	}
	$currentPeer->{channels} = [];
	for (my $i = 0; $i < $channelCount; $i++) {
		$currentPeer->{channels}->[$i] = ENetChannel->new();
	}
	if (!defined($currentPeer->{channels})) {
		return undef;
	}
	$currentPeer->{channel_count} = $channelCount;
	$currentPeer->{state} = 1;
	$currentPeer->{address} = ENetAddress::clone($address);
	$currentPeer->{connect_i_d} = ++$host->{random_seed};
	if ($host->{outgoing_bandwidth} == 0) {
		$currentPeer->{window_size} = 32768;
	}
	else {
		$currentPeer->{window_size} = $host->{outgoing_bandwidth} / 65536 * 4096;
	}
	if ($currentPeer->{window_size} < 4096) {
		$currentPeer->{window_size} = 4096;
	}
	elsif ($currentPeer->{window_size} > 32768) {
		$currentPeer->{window_size} = 32768;
	}
	for (my $i = 0; $i < $channelCount; $i++) {
		$channel = $currentPeer->{channels}->[$i];
		$channel->{outgoing_reliable_sequence_number} = 0;
		$channel->{outgoing_unreliable_sequence_number} = 0;
		$channel->{incoming_reliable_sequence_number} = 0;
		$channel->{incoming_unreliable_sequence_number} = 0;
		$self->enet_list_clear($channel->{incoming_reliable_commands});
		$self->enet_list_clear($channel->{incoming_unreliable_commands});
		$channel->{used_reliable_windows} = 0;
		for (my $k = 0; $k < 16; $k++) {
			$channel->{reliable_windows}->[$k] = 0;
		}
	}
	$command->{header} = ENetProtocolCommandHeader->new();
	$command->{header}->{command} = 130;
	$command->{header}->{channel_i_d} = 255;
	$command->{connect} = ENetProtocolConnect->new();
	$command->{connect}->{outgoing_peer_i_d} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($currentPeer->{incoming_peer_i_d});
	$command->{connect}->{incoming_session_i_d} = $currentPeer->{incoming_session_i_d};
	$command->{connect}->{outgoing_session_i_d} = $currentPeer->{outgoing_session_i_d};
	$command->{connect}->{mtu} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{mtu});
	$command->{connect}->{window_size} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{window_size});
	$command->{connect}->{channel_count} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($channelCount);
	$command->{connect}->{incoming_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($host->{incoming_bandwidth});
	$command->{connect}->{outgoing_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($host->{outgoing_bandwidth});
	$command->{connect}->{packet_throttle_interval} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_interval});
	$command->{connect}->{packet_throttle_acceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_acceleration});
	$command->{connect}->{packet_throttle_deceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_deceleration});
	$command->{connect}->{connect_i_d} = $currentPeer->{connect_i_d};
	$command->{connect}->{data} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($data);
	$self->enet_peer_queue_outgoing_command($currentPeer, $command, undef, 0, 0);
	return $currentPeer;
}

=head2 C<$enet-E<gt>enet_host_create($address, $peerCount, $channelLimit, $incomingBandwidth, $outgoingBandwidth)>

Creates a host for communicating to peers.  
@remarks ENet will strategically drop packets on specific sides of a connection between hosts
to ensure the host's bandwidth is not overwhelmed.  The bandwidth parameters also determine
the window size of a connection which limits the amount of reliable packets that may be in transit
at any given time.

Parameters:

=over

=item $address

the address at which other peers may connect to this host.  If NULL, then no peers may connect to the host.

=item $peerCount

the maximum number of peers that should be allocated for the host.

=item $channelLimit

the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT

=item $incomingBandwidth

downstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.

=item $outgoingBandwidth

upstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.

=back

=cut

sub enet_host_create($$$$$$) {
	my ($self, $address, $peerCount, $channelLimit, $incomingBandwidth, $outgoingBandwidth) = @_;
	my $host;
	my $currentPeer;
	if ($peerCount > 4095) {
		return undef;
	}
	$host = ENetHost->new();
	if (!defined($host)) {
		return undef;
	}
	$host->{peers} = [];
	if (!defined($host->{peers})) {
		return undef;
	}
	for (my $i = 0; $i < $peerCount; $i++) {
		$host->{peers}->[$i] = ENetPeer->new();
	}
	$host->{socket} = $self->{p}->enet_socket_create(2);
	if (defined($host->{socket}) && $host->{socket}->n_u_l_l() || defined($address) && $self->{p}->enet_socket_bind($host->{socket}, $address) < 0) {
		if (defined($host->{socket}) && !$host->{socket}->n_u_l_l()) {
			$self->{p}->enet_socket_destroy($host->{socket});
		}
		return undef;
	}
	$self->{p}->enet_socket_set_option($host->{socket}, 1, 1);
	$self->{p}->enet_socket_set_option($host->{socket}, 2, 1);
	$self->{p}->enet_socket_set_option($host->{socket}, 3, 262144);
	$self->{p}->enet_socket_set_option($host->{socket}, 4, 262144);
	if (defined($address) && $self->{p}->enet_socket_get_address($host->{socket}, $host->{address}) < 0) {
		$host->{address} = $address;
	}
	if ($channelLimit == 0 || $channelLimit > 255) {
		$channelLimit = 255;
	}
	elsif ($channelLimit < 1) {
		$channelLimit = 1;
	}
	$host->{random_seed} = 0;
	$host->{random_seed} += $self->{p}->time();
	$host->{random_seed} = $host->{random_seed} << 16 | $host->{random_seed} >> 16;
	$host->{channel_limit} = $channelLimit;
	$host->{incoming_bandwidth} = $incomingBandwidth;
	$host->{outgoing_bandwidth} = $outgoingBandwidth;
	$host->{bandwidth_throttle_epoch} = 0;
	$host->{recalculate_bandwidth_limits} = 0;
	$host->{mtu} = 1400;
	$host->{peer_count} = $peerCount;
	$host->{command_count} = 0;
	$host->{buffer_count} = 0;
	$host->{checksum} = undef;
	$host->{received_address} = ENetAddress->new();
	$host->{received_address}->{host} = 0;
	$host->{received_address}->{port} = 0;
	$host->{received_data} = undef;
	$host->{received_data_length} = 0;
	$host->{total_sent_data} = 0;
	$host->{total_sent_packets} = 0;
	$host->{total_received_data} = 0;
	$host->{total_received_packets} = 0;
	$host->{connected_peers} = 0;
	$host->{bandwidth_limited_peers} = 0;
	$host->{compressor} = undef;
	$host->{intercept} = undef;
	$host->{dispatch_queue} = ENetPeer->new();
	$host->{dispatch_queue}->set_sentinel(ENetPeer->new());
	$self->enet_list_clear($host->{dispatch_queue});
	for (my $i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		$currentPeer->{host} = $host;
		$currentPeer->{incoming_peer_i_d} = $self->{p}->int_to_ushort($i);
		$currentPeer->{outgoing_session_i_d} = $currentPeer->{incoming_session_i_d} = 255;
		$currentPeer->{data} = undef;
		$self->enet_list_clear($currentPeer->{acknowledgements});
		$self->enet_list_clear($currentPeer->{sent_reliable_commands});
		$self->enet_list_clear($currentPeer->{sent_unreliable_commands});
		$self->enet_list_clear($currentPeer->{outgoing_reliable_commands});
		$self->enet_list_clear($currentPeer->{outgoing_unreliable_commands});
		$self->enet_list_clear($currentPeer->{dispatched_commands});
		$self->enet_peer_reset($currentPeer);
	}
	return $host;
}

=head2 C<$enet-E<gt>enet_host_destroy($host)>

Destroys the host and all resources associated with it.

Parameters:

=over

=item $host

pointer to the host to destroy

=back

=cut

sub enet_host_destroy($$) {
	my ($self, $host) = @_;
	my $currentPeer;
	if (!defined($host)) {
		return;
	}
	$self->{p}->enet_socket_destroy($host->{socket});
	for (my $i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		$self->enet_peer_reset($currentPeer);
	}
	if (defined($host->{compressor})) {
		$host->{compressor}->destroy();
	}
}

=head2 C<$enet-E<gt>enet_host_flush($host)>

Sends any queued packets on the host specified to its designated peers.

Parameters:

=over

=item $host

host to flush

=back

=cut

sub enet_host_flush($$) {
	my ($self, $host) = @_;
	$host->{service_time} = $self->{p}->enet_time_get();
	$self->enet_protocol_send_outgoing_commands($host, undef, 0);
}

=head2 C<$enet-E<gt>enet_host_service($host, $event_, $timeout)>

Waits for events on the host specified and shuttles packets between the host and its peers.

Parameters:

=over

=item $host

host to service

=item $event_

an event structure where event details will be placed if one occurs
if event == null then no events will be delivered

=item $timeout

number of milliseconds that ENet should wait for events

=back

=cut

sub enet_host_service($$$$) {
	my ($self, $host, $event_, $timeout) = @_;
	my $waitCondition = [];
	if (defined($event_)) {
		$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E();
		$event_->{peer} = undef;
		$event_->{packet} = undef;
		given ($self->enet_protocol_dispatch_incoming_commands($host, $event_)) {
			when (1) {
				return 1;
			}
			when (-1) {
				return -1;
			}
		}
	}
	$host->{service_time} = $self->{p}->enet_time_get();
	$timeout += $host->{service_time};
	do {
		if ($self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $host->{bandwidth_throttle_epoch}) >= 1000) {
			$self->enet_host_bandwidth_throttle($host);
		}
		given ($self->enet_protocol_send_outgoing_commands($host, $event_, 1)) {
			when (1) {
				return 1;
			}
			when (-1) {
				return -1;
			}
		}
		given ($self->enet_protocol_receive_incoming_commands($host, $event_)) {
			when (1) {
				return 1;
			}
			when (-1) {
				return -1;
			}
		}
		given ($self->enet_protocol_send_outgoing_commands($host, $event_, 1)) {
			when (1) {
				return 1;
			}
			when (-1) {
				return -1;
			}
		}
		if (defined($event_)) {
			given ($self->enet_protocol_dispatch_incoming_commands($host, $event_)) {
				when (1) {
					return 1;
				}
				when (-1) {
					return -1;
				}
			}
		}
		do {
			$host->{service_time} = $self->{p}->enet_time_get();
			if ($self->e_n_e_t__t_i_m_e__g_r_e_a_t_e_r__e_q_u_a_l($host->{service_time}, $timeout)) {
				return 0;
			}
			$waitCondition->[0] = 6;
			if ($self->{p}->enet_socket_wait($host->{socket}, $waitCondition, $self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($timeout, $host->{service_time})) != 0) {
				return -1;
			}
		}
		while ($waitCondition->[0] & 4) != 0;
		$host->{service_time} = $self->{p}->enet_time_get();
	}
	while ($waitCondition->[0] & 2) != 0;
	return 0;
}

=head2 C<$enet-E<gt>enet_initialize()>

=cut

sub enet_initialize($) {
	my ($self) = @_;
	return 0;
}

sub enet_list_back($$) {
	my ($self, $list) = @_;
	return $self->{p}->cast_to_e_net_list_node($self->{p}->cast_to_e_net_list_node($list->get_sentinel())->{previous});
}

sub enet_list_begin($$) {
	my ($self, $list) = @_;
	return $self->{p}->cast_to_e_net_list_node($self->{p}->cast_to_e_net_list_node($list->get_sentinel())->{next});
}

sub enet_list_clear($$) {
	my ($self, $list) = @_;
	$self->{p}->cast_to_e_net_list_node($list->get_sentinel())->{next} = $list->get_sentinel();
	$self->{p}->cast_to_e_net_list_node($list->get_sentinel())->{previous} = $list->get_sentinel();
}

sub enet_list_empty($$) {
	my ($self, $list) = @_;
	return $self->enet_list_begin($list) == $self->enet_list_end($list);
}

sub enet_list_end($$) {
	my ($self, $list) = @_;
	return $self->{p}->cast_to_e_net_list_node($list->get_sentinel());
}

sub enet_list_front($$) {
	my ($self, $list) = @_;
	return $self->{p}->cast_to_e_net_list_node($self->{p}->cast_to_e_net_list_node($list->get_sentinel())->{next});
}

sub enet_list_insert($$$) {
	my ($self, $position, $data) = @_;
	my $result = $self->{p}->cast_to_e_net_list_node($data);
	$result->{previous} = $position->{previous};
	$result->{next} = $position;
	$self->{p}->cast_to_e_net_list_node($result->{previous})->{next} = $result;
	$position->{previous} = $result;
	return $result;
}

sub enet_list_move($$$$) {
	my ($self, $position, $dataFirst, $dataLast) = @_;
	my $first = $dataFirst;
	my $last = $dataLast;
	$self->{p}->cast_to_e_net_list_node($first->{previous})->{next} = $last->{next};
	$self->{p}->cast_to_e_net_list_node($last->{next})->{previous} = $first->{previous};
	$first->{previous} = $position->{previous};
	$last->{next} = $position;
	$self->{p}->cast_to_e_net_list_node($first->{previous})->{next} = $first;
	$position->{previous} = $last;
	return $first;
}

sub enet_list_next($$) {
	my ($self, $iterator) = @_;
	return $self->{p}->cast_to_e_net_list_node($iterator->{next});
}

sub enet_list_previous($$) {
	my ($self, $iterator) = @_;
	return $self->{p}->cast_to_e_net_list_node($iterator->{previous});
}

sub enet_list_remove($$) {
	my ($self, $position) = @_;
	$self->{p}->cast_to_e_net_list_node($position->{previous})->{next} = $position->{next};
	$self->{p}->cast_to_e_net_list_node($position->{next})->{previous} = $position->{previous};
	return $position;
}

sub enet_list_size($$) {
	my ($self, $list) = @_;
	my $size = 0;
	my $position;
	for ($position = $self->enet_list_begin($list); $position != $self->enet_list_end($list); $position = $self->enet_list_next($position)) {
		$size++;
	}
	return $size;
}

=head2 C<$enet-E<gt>enet_packet_create(\@data, $dataLength, $flags)>

Creates a packet that may be sent to a peer.

Parameters:

=over

=item \@data

initial contents of the packet's data; the packet's data will remain uninitialized if dataContents is NULL.

=item $dataLength

size of the data allocated for this packet

=item $flags

flags for this packet as described for the ENetPacket structure.

=back

=cut

sub enet_packet_create($$$$) {
	my ($self, $data, $dataLength, $flags) = @_;
	my $packet = ENetPacket->new();
	if (!defined($packet)) {
		return undef;
	}
	if (($flags & 4) != 0) {
		$packet->{data} = $data;
	}
	elsif ($dataLength <= 0) {
		$packet->{data} = undef;
	}
	else {
		$packet->{data} = [];
		if (!defined($packet->{data})) {
			return undef;
		}
		if (defined($data)) {
			for (my $i = 0; $i < $dataLength; $i++) {
				$packet->{data}->[$i] = $data->[$i];
			}
		}
	}
	$packet->{reference_count} = 0;
	$packet->{flags} = $flags;
	$packet->{data_length} = $dataLength;
	$packet->{free_callback} = undef;
	$packet->{user_data} = undef;
	return $packet;
}

=head2 C<$enet-E<gt>enet_packet_destroy($packet)>

Destroys the packet and deallocates its data.

Parameters:

=over

=item $packet

packet to be destroyed

=back

=cut

sub enet_packet_destroy($$) {
	my ($self, $packet) = @_;
	if (!defined($packet)) {
		return;
	}
	if (defined($packet->{free_callback})) {
		$packet->{free_callback}->run($packet);
	}
	if (($packet->{flags} & 4) == 0 && defined($packet->{data})) {
	}
}

=head2 C<$enet-E<gt>enet_packet_resize($packet, $dataLength)>

=cut

sub enet_packet_resize($$$) {
	my ($self, $packet, $dataLength) = @_;
	my $newData;
	if ($dataLength <= $packet->{data_length} || ($packet->{flags} & 4) != 0) {
		$packet->{data_length} = $dataLength;
		return 0;
	}
	$newData = [];
	if (!defined($newData)) {
		return -1;
	}
	$self->memcpy($newData, $packet->{data}, $packet->{data_length});
	$packet->{data} = $newData;
	$packet->{data_length} = $dataLength;
	return 0;
}

=head2 C<$enet-E<gt>enet_peer_disconnect($peer, $data)>

Request a disconnection from a peer.

Parameters:

=over

=item $peer

peer to request a disconnection

=item $data

data describing the disconnection

=back

=cut

sub enet_peer_disconnect($$$) {
	my ($self, $peer, $data) = @_;
	my $command = ENetProtocol->new();
	if ($peer->{state} == 7 || $peer->{state} == 0 || $peer->{state} == 8 || $peer->{state} == 9) {
		return;
	}
	$self->enet_peer_reset_queues($peer);
	$command->{header}->{command} = 4;
	$command->{header}->{channel_i_d} = 255;
	$command->{disconnect}->{data} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($data);
	if ($peer->{state} == 5 || $peer->{state} == 6) {
		$command->{header}->{command} |= 128;
	}
	else {
		$command->{header}->{command} |= 64;
	}
	$self->enet_peer_queue_outgoing_command($peer, $command, undef, 0, 0);
	if ($peer->{state} == 5 || $peer->{state} == 6) {
		$self->enet_peer_on_disconnect($peer);
		$peer->{state} = 7;
	}
	else {
		$self->enet_host_flush($peer->{host});
		$self->enet_peer_reset($peer);
	}
}

=head2 C<$enet-E<gt>enet_peer_disconnect_later($peer, $data)>

Request a disconnection from a peer, but only after all queued outgoing packets are sent.

Parameters:

=over

=item $peer

peer to request a disconnection

=item $data

data describing the disconnection

=back

=cut

sub enet_peer_disconnect_later($$$) {
	my ($self, $peer, $data) = @_;
	if (($peer->{state} == 5 || $peer->{state} == 6) && !($self->enet_list_empty($peer->{outgoing_reliable_commands}) && $self->enet_list_empty($peer->{outgoing_unreliable_commands}) && $self->enet_list_empty($peer->{sent_reliable_commands}))) {
		$peer->{state} = 6;
		$peer->{event_data} = $data;
	}
	else {
		$self->enet_peer_disconnect($peer, $data);
	}
}

=head2 C<$enet-E<gt>enet_peer_disconnect_now($peer, $data)>

Force an immediate disconnection from a peer.

Parameters:

=over

=item $peer

peer to disconnect

=item $data

data describing the disconnection

=back

=cut

sub enet_peer_disconnect_now($$$) {
	my ($self, $peer, $data) = @_;
	my $command = ENetProtocol->new();
	if ($peer->{state} == 0) {
		return;
	}
	if ($peer->{state} != 9 && $peer->{state} != 7) {
		$self->enet_peer_reset_queues($peer);
		$command->{header}->{command} = 68;
		$command->{header}->{channel_i_d} = 255;
		$command->{disconnect}->{data} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($data);
		$self->enet_peer_queue_outgoing_command($peer, $command, undef, 0, 0);
		$self->enet_host_flush($peer->{host});
	}
	$self->enet_peer_reset($peer);
}

sub enet_peer_dispatch_incoming_reliable_commands($$$) {
	my ($self, $peer, $channel) = @_;
	my $currentCommand;
	for ($currentCommand = $self->enet_list_begin($channel->{incoming_reliable_commands}); $currentCommand != $self->enet_list_end($channel->{incoming_reliable_commands}); $currentCommand = $self->enet_list_next($currentCommand)) {
		my $incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
		if ($incomingCommand->{fragments_remaining} > 0 || $incomingCommand->{reliable_sequence_number} != $self->{p}->int_to_ushort($channel->{incoming_reliable_sequence_number} + 1)) {
			last;
		}
		$channel->{incoming_reliable_sequence_number} = $incomingCommand->{reliable_sequence_number};
		if ($incomingCommand->{fragment_count} > 0) {
			$channel->{incoming_reliable_sequence_number} += $incomingCommand->{fragment_count} - 1;
		}
	}
	if ($currentCommand == $self->enet_list_begin($channel->{incoming_reliable_commands})) {
		return;
	}
	$channel->{incoming_unreliable_sequence_number} = 0;
	$self->enet_list_move($self->enet_list_end($peer->{dispatched_commands}), $self->enet_list_begin($channel->{incoming_reliable_commands}), $self->enet_list_previous($currentCommand));
	if ($peer->{needs_dispatch} == 0) {
		$self->enet_list_insert($self->enet_list_end($peer->{host}->{dispatch_queue}), $peer->dispatch_list());
		$peer->{needs_dispatch} = 1;
	}
	if (!$self->enet_list_empty($channel->{incoming_unreliable_commands})) {
		$self->enet_peer_dispatch_incoming_unreliable_commands($peer, $channel);
	}
}

sub enet_peer_dispatch_incoming_unreliable_commands($$$) {
	my ($self, $peer, $channel) = @_;
	my $droppedCommand;
	my $startCommand;
	my $currentCommand;
	for ($droppedCommand = $startCommand = $currentCommand = $self->enet_list_begin($channel->{incoming_unreliable_commands}); $currentCommand != $self->enet_list_end($channel->{incoming_unreliable_commands}); $currentCommand = $self->enet_list_next($currentCommand)) {
		my $incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
		if (($incomingCommand->{command}->{header}->{command} & 15) == 9) {
			next;
		}
		if ($incomingCommand->{reliable_sequence_number} == $channel->{incoming_reliable_sequence_number}) {
			if ($incomingCommand->{fragments_remaining} <= 0) {
				$channel->{incoming_unreliable_sequence_number} = $incomingCommand->{unreliable_sequence_number};
				next;
			}
			if ($startCommand != $currentCommand) {
				$self->enet_list_move($self->enet_list_end($peer->{dispatched_commands}), $startCommand, $self->enet_list_previous($currentCommand));
				if ($peer->{needs_dispatch} == 0) {
					$self->enet_list_insert($self->enet_list_end($peer->{host}->{dispatch_queue}), $peer->dispatch_list());
					$peer->{needs_dispatch} = 1;
				}
				$droppedCommand = $currentCommand;
			}
			elsif ($droppedCommand != $currentCommand) {
				$droppedCommand = $self->enet_list_previous($currentCommand);
			}
		}
		else {
			my $reliableWindow = $self->{p}->int_to_ushort($incomingCommand->{reliable_sequence_number} / 4096);
			my $currentWindow = $self->{p}->int_to_ushort($channel->{incoming_reliable_sequence_number} / 4096);
			if ($incomingCommand->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
				$reliableWindow += 16;
			}
			if ($reliableWindow >= $currentWindow && $reliableWindow < $currentWindow + 8 - 1) {
				last;
			}
			$droppedCommand = $self->enet_list_next($currentCommand);
			if ($startCommand != $currentCommand) {
				$self->enet_list_move($self->enet_list_end($peer->{dispatched_commands}), $startCommand, $self->enet_list_previous($currentCommand));
				if ($peer->{needs_dispatch} == 0) {
					$self->enet_list_insert($self->enet_list_end($peer->{host}->{dispatch_queue}), $peer->dispatch_list());
					$peer->{needs_dispatch} = 1;
				}
			}
		}
		$startCommand = $self->enet_list_next($currentCommand);
	}
	if ($startCommand != $currentCommand) {
		$self->enet_list_move($self->enet_list_end($peer->{dispatched_commands}), $startCommand, $self->enet_list_previous($currentCommand));
		if ($peer->{needs_dispatch} == 0) {
			$self->enet_list_insert($self->enet_list_end($peer->{host}->{dispatch_queue}), $peer->dispatch_list());
			$peer->{needs_dispatch} = 1;
		}
		$droppedCommand = $currentCommand;
	}
	$self->enet_peer_remove_incoming_commands($channel->{incoming_unreliable_commands}, $self->enet_list_begin($channel->{incoming_unreliable_commands}), $droppedCommand);
}

sub enet_peer_on_connect($$) {
	my ($self, $peer) = @_;
	if ($peer->{state} != 5 && $peer->{state} != 6) {
		if ($peer->{incoming_bandwidth} != 0) {
			$peer->{host}->{bandwidth_limited_peers}++;
		}
		$peer->{host}->{connected_peers}++;
	}
}

sub enet_peer_on_disconnect($$) {
	my ($self, $peer) = @_;
	if ($peer->{state} == 5 || $peer->{state} == 6) {
		if ($peer->{incoming_bandwidth} != 0) {
			$peer->{host}->{bandwidth_limited_peers}--;
		}
		$peer->{host}->{connected_peers}--;
	}
}

=head2 C<$enet-E<gt>enet_peer_ping($peer)>

Sends a ping request to a peer.

Parameters:

=over

=item $peer

destination for the ping request

=back

=cut

sub enet_peer_ping($$) {
	my ($self, $peer) = @_;
	my $command = ENetProtocol->new();
	if ($peer->{state} != 5) {
		return;
	}
	$command->{header}->{command} = 133;
	$command->{header}->{channel_i_d} = 255;
	$self->enet_peer_queue_outgoing_command($peer, $command, undef, 0, 0);
}

=head2 C<$enet-E<gt>enet_peer_ping_interval($peer, $pingInterval)>

Sets the interval at which pings will be sent to a peer. 
Pings are used both to monitor the liveness of the connection and also to dynamically
adjust the throttle during periods of low traffic so that the throttle has reasonable
responsiveness during traffic spikes.

Parameters:

=over

=item $peer

the peer to adjust

=item $pingInterval

the interval at which to send pings; defaults to ENET_PEER_PING_INTERVAL if 0

=back

=cut

sub enet_peer_ping_interval($$$) {
	my ($self, $peer, $pingInterval) = @_;
	$peer->{ping_interval} = $pingInterval != 0 ? $pingInterval : 500;
}

sub enet_peer_queue_acknowledgement($$$$) {
	my ($self, $peer, $command, $sentTime) = @_;
	my $acknowledgement;
	if ($command->{header}->{channel_i_d} < $peer->{channel_count}) {
		my $channel = $peer->{channels}->[$command->{header}->{channel_i_d}];
		my $reliableWindow = $self->{p}->int_to_ushort($command->{header}->{reliable_sequence_number} / 4096);
		my $currentWindow = $self->{p}->int_to_ushort($channel->{incoming_reliable_sequence_number} / 4096);
		if ($command->{header}->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
			$reliableWindow += 16;
		}
		if ($reliableWindow >= $currentWindow + 8 - 1 && $reliableWindow <= $currentWindow + 8) {
			return undef;
		}
	}
	$acknowledgement = ENetAcknowledgement->new();
	if (!defined($acknowledgement)) {
		return undef;
	}
	$peer->{outgoing_data_total} += 8;
	$acknowledgement->{sent_time} = $sentTime;
	$acknowledgement->{command} = $command;
	$self->enet_list_insert($self->enet_list_end($peer->{acknowledgements}), $acknowledgement);
	return $acknowledgement;
}

sub enet_peer_queue_incoming_command($$$$$) {
	my ($self, $peer, $command, $packet, $fragmentCount) = @_;
	my $channel = $peer->{channels}->[$command->{header}->{channel_i_d}];
	my $unreliableSequenceNumber = 0;
	my $reliableSequenceNumber = 0;
	my $reliableWindow;
	my $currentWindow;
	my $incomingCommand = undef;
	my $currentCommand;
	if ($peer->{state} == 6) {
		return $self->free_packet($fragmentCount, $packet);
	}
	if (($command->{header}->{command} & 15) != 9) {
		$reliableSequenceNumber = $command->{header}->{reliable_sequence_number};
		$reliableWindow = $reliableSequenceNumber / 4096;
		$currentWindow = $channel->{incoming_reliable_sequence_number} / 4096;
		if ($reliableSequenceNumber < $channel->{incoming_reliable_sequence_number}) {
			$reliableWindow += 16;
		}
		if ($reliableWindow < $currentWindow || $reliableWindow >= $currentWindow + 8 - 1) {
			return $self->free_packet($fragmentCount, $packet);
		}
	}
	given ($command->{header}->{command} & 15) {
		when ([ 8, 6 ]) {
			if ($reliableSequenceNumber == $channel->{incoming_reliable_sequence_number}) {
				return $self->free_packet($fragmentCount, $packet);
			}
			for ($currentCommand = $self->enet_list_previous($self->enet_list_end($channel->{incoming_reliable_commands})); $currentCommand != $self->enet_list_end($channel->{incoming_reliable_commands}); $currentCommand = $self->enet_list_previous($currentCommand)) {
				$incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
				if ($reliableSequenceNumber >= $channel->{incoming_reliable_sequence_number}) {
					if ($incomingCommand->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
						next;
					}
				}
				elsif ($incomingCommand->{reliable_sequence_number} >= $channel->{incoming_reliable_sequence_number}) {
					last;
				}
				if ($incomingCommand->{reliable_sequence_number} <= $reliableSequenceNumber) {
					if ($incomingCommand->{reliable_sequence_number} < $reliableSequenceNumber) {
						last;
					}
					return $self->free_packet($fragmentCount, $packet);
				}
			}
		}
		when ([ 7, 12 ]) {
			$unreliableSequenceNumber = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_unreliable}->{unreliable_sequence_number});
			if ($reliableSequenceNumber == $channel->{incoming_reliable_sequence_number} && $unreliableSequenceNumber <= $channel->{incoming_unreliable_sequence_number}) {
				return $self->free_packet($fragmentCount, $packet);
			}
			for ($currentCommand = $self->enet_list_previous($self->enet_list_end($channel->{incoming_unreliable_commands})); $currentCommand != $self->enet_list_end($channel->{incoming_unreliable_commands}); $currentCommand = $self->enet_list_previous($currentCommand)) {
				$incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
				if (($command->{header}->{command} & 15) == 9) {
					next;
				}
				if ($reliableSequenceNumber >= $channel->{incoming_reliable_sequence_number}) {
					if ($incomingCommand->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
						next;
					}
				}
				elsif ($incomingCommand->{reliable_sequence_number} >= $channel->{incoming_reliable_sequence_number}) {
					last;
				}
				if ($incomingCommand->{reliable_sequence_number} < $reliableSequenceNumber) {
					last;
				}
				if ($incomingCommand->{reliable_sequence_number} > $reliableSequenceNumber) {
					next;
				}
				if ($incomingCommand->{unreliable_sequence_number} <= $unreliableSequenceNumber) {
					if ($incomingCommand->{unreliable_sequence_number} < $unreliableSequenceNumber) {
						last;
					}
					return $self->free_packet($fragmentCount, $packet);
				}
			}
		}
		when (9) {
			$currentCommand = $self->enet_list_end($channel->{incoming_unreliable_commands});
		}
		default {
			return $self->free_packet($fragmentCount, $packet);
		}
	}
	$incomingCommand = ENetIncomingCommand->new();
	if (!defined($incomingCommand)) {
		return $self->notify_error($packet);
	}
	$incomingCommand->{reliable_sequence_number} = $command->{header}->{reliable_sequence_number};
	$incomingCommand->{unreliable_sequence_number} = $self->{p}->int_to_ushort($unreliableSequenceNumber & 65535);
	$incomingCommand->{command} = $command;
	$incomingCommand->{fragment_count} = $fragmentCount;
	$incomingCommand->{fragments_remaining} = $fragmentCount;
	$incomingCommand->{packet} = $packet;
	$incomingCommand->{fragments} = undef;
	if ($fragmentCount > 0) {
		if ($fragmentCount <= 1048576) {
			$incomingCommand->{fragments} = [];
		}
		if (!defined($incomingCommand->{fragments})) {
			return $self->notify_error($packet);
		}
		for (my $i = 0; $i < ($fragmentCount + 31) / 32; $i++) {
			$incomingCommand->{fragments}->[$i] = 0;
		}
	}
	if (defined($packet)) {
		$packet->{reference_count}++;
	}
	$self->enet_list_insert($self->enet_list_next($currentCommand), $incomingCommand);
	given ($command->{header}->{command} & 15) {
		when ([ 8, 6 ]) {
			$self->enet_peer_dispatch_incoming_reliable_commands($peer, $channel);
		}
		default {
			$self->enet_peer_dispatch_incoming_unreliable_commands($peer, $channel);
		}
	}
	return $incomingCommand;
}

sub enet_peer_queue_outgoing_command($$$$$$) {
	my ($self, $peer, $command, $packet, $offset, $length) = @_;
	my $outgoingCommand = ENetOutgoingCommand->new();
	if (!defined($outgoingCommand)) {
		return undef;
	}
	$outgoingCommand->{command} = $command;
	$outgoingCommand->{fragment_offset} = $offset;
	$outgoingCommand->{fragment_length} = $length;
	$outgoingCommand->{packet} = $packet;
	if (defined($packet)) {
		$packet->{reference_count}++;
	}
	$self->enet_peer_setup_outgoing_command($peer, $outgoingCommand);
	return $outgoingCommand;
}

=head2 C<$enet-E<gt>enet_peer_receive($peer, $channelID)>

Attempts to dequeue any incoming queued packet.

Parameters:

=over

=item $peer

peer to dequeue packets from

=item $channelID

holds the channel ID of the channel the packet was received on success

=back

=cut

sub enet_peer_receive($$$) {
	my ($self, $peer, $channelID) = @_;
	my $incomingCommand;
	my $packet;
	if ($self->enet_list_empty($peer->{dispatched_commands})) {
		return undef;
	}
	$incomingCommand = $self->{p}->cast_to_e_net_incoming_command($self->enet_list_remove($self->enet_list_begin($peer->{dispatched_commands})));
	if (defined($channelID)) {
		$channelID->{value} = $incomingCommand->{command}->{header}->{channel_i_d};
	}
	$packet = $incomingCommand->{packet};
	$packet->{reference_count}--;
	if (defined($incomingCommand->{fragments})) {
	}
	return $packet;
}

=head2 C<$enet-E<gt>enet_peer_remove_incoming_commands($queue, $startCommand, $endCommand)>

=cut

sub enet_peer_remove_incoming_commands($$$$) {
	my ($self, $queue, $startCommand, $endCommand) = @_;
	my $currentCommand;
	for ($currentCommand = $startCommand; $currentCommand != $endCommand;) {
		my $incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
		$currentCommand = $self->enet_list_next($currentCommand);
		$self->enet_list_remove($incomingCommand->incoming_command_list());
		if (defined($incomingCommand->{packet})) {
			$incomingCommand->{packet}->{reference_count}--;
			if ($incomingCommand->{packet}->{reference_count} == 0) {
				$self->enet_packet_destroy($incomingCommand->{packet});
			}
		}
		if (defined($incomingCommand->{fragments})) {
		}
	}
}

=head2 C<$enet-E<gt>enet_peer_reset($peer)>

Forcefully disconnects a peer.

Parameters:

=over

=item $peer

peer to forcefully disconnect

=back

=cut

sub enet_peer_reset($$) {
	my ($self, $peer) = @_;
	$self->enet_peer_on_disconnect($peer);
	$peer->{outgoing_peer_i_d} = 4095;
	$peer->{connect_i_d} = 0;
	$peer->{state} = 0;
	$peer->{incoming_bandwidth} = 0;
	$peer->{outgoing_bandwidth} = 0;
	$peer->{incoming_bandwidth_throttle_epoch} = 0;
	$peer->{outgoing_bandwidth_throttle_epoch} = 0;
	$peer->{incoming_data_total} = 0;
	$peer->{outgoing_data_total} = 0;
	$peer->{last_send_time} = 0;
	$peer->{last_receive_time} = 0;
	$peer->{next_timeout} = 0;
	$peer->{earliest_timeout} = 0;
	$peer->{packet_loss_epoch} = 0;
	$peer->{packets_sent} = 0;
	$peer->{packets_lost} = 0;
	$peer->{packet_loss} = 0;
	$peer->{packet_loss_variance} = 0;
	$peer->{packet_throttle} = 32;
	$peer->{packet_throttle_limit} = 32;
	$peer->{packet_throttle_counter} = 0;
	$peer->{packet_throttle_epoch} = 0;
	$peer->{packet_throttle_acceleration} = 2;
	$peer->{packet_throttle_deceleration} = 2;
	$peer->{packet_throttle_interval} = 5000;
	$peer->{ping_interval} = 500;
	$peer->{timeout_limit} = 32;
	$peer->{timeout_minimum} = 5000;
	$peer->{timeout_maximum} = 30000;
	$peer->{last_round_trip_time} = 500;
	$peer->{lowest_round_trip_time} = 500;
	$peer->{last_round_trip_time_variance} = 0;
	$peer->{highest_round_trip_time_variance} = 0;
	$peer->{round_trip_time} = 500;
	$peer->{round_trip_time_variance} = 0;
	$peer->{mtu} = $peer->{host}->{mtu};
	$peer->{reliable_data_in_transit} = 0;
	$peer->{outgoing_reliable_sequence_number} = 0;
	$peer->{window_size} = 32768;
	$peer->{incoming_unsequenced_group} = 0;
	$peer->{outgoing_unsequenced_group} = 0;
	$peer->{event_data} = 0;
	for (my $i = 0; $i < 32; $i++) {
		$peer->{unsequenced_window}->[$i] = 0;
	}
	$self->enet_peer_reset_queues($peer);
}

=head2 C<$enet-E<gt>enet_peer_reset_incoming_commands($queue)>

=cut

sub enet_peer_reset_incoming_commands($$) {
	my ($self, $queue) = @_;
	$self->enet_peer_remove_incoming_commands($queue, $self->enet_list_begin($queue), $self->enet_list_end($queue));
}

=head2 C<$enet-E<gt>enet_peer_reset_outgoing_commands($queue)>

=cut

sub enet_peer_reset_outgoing_commands($$) {
	my ($self, $queue) = @_;
	my $outgoingCommand;
	while (!$self->enet_list_empty($queue)) {
		$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($self->enet_list_remove($self->enet_list_begin($queue)));
		if (defined($outgoingCommand->{packet})) {
			$outgoingCommand->{packet}->{reference_count}--;
			if ($outgoingCommand->{packet}->{reference_count} == 0) {
				$self->enet_packet_destroy($outgoingCommand->{packet});
			}
		}
	}
}

=head2 C<$enet-E<gt>enet_peer_reset_queues($peer)>

=cut

sub enet_peer_reset_queues($$) {
	my ($self, $peer) = @_;
	my $channel;
	if ($peer->{needs_dispatch} != 0) {
		$self->enet_list_remove($peer->dispatch_list());
		$peer->{needs_dispatch} = 0;
	}
	while (!$self->enet_list_empty($peer->{acknowledgements})) {
		my $n = $self->enet_list_remove($self->enet_list_begin($peer->{acknowledgements}));
	}
	$self->enet_peer_reset_outgoing_commands($peer->{sent_reliable_commands});
	$self->enet_peer_reset_outgoing_commands($peer->{sent_unreliable_commands});
	$self->enet_peer_reset_outgoing_commands($peer->{outgoing_reliable_commands});
	$self->enet_peer_reset_outgoing_commands($peer->{outgoing_unreliable_commands});
	$self->enet_peer_reset_incoming_commands($peer->{dispatched_commands});
	if (defined($peer->{channels}) && $peer->{channel_count} > 0) {
		for (my $i = 0; $i < $peer->{channel_count}; $i++) {
			$channel = $peer->{channels}->[$i];
			$self->enet_peer_reset_incoming_commands($channel->{incoming_reliable_commands});
			$self->enet_peer_reset_incoming_commands($channel->{incoming_unreliable_commands});
		}
	}
	$peer->{channels} = undef;
	$peer->{channel_count} = 0;
}

=head2 C<$enet-E<gt>enet_peer_send($peer, $channelID, $packet)>

Queues a packet to be sent.

Parameters:

=over

=item $peer

destination for the packet

=item $channelID

channel on which to send

=item $packet

packet to send

=back

=cut

sub enet_peer_send($$$$) {
	my ($self, $peer, $channelID, $packet) = @_;
	my $channel = $peer->{channels}->[$channelID];
	my $command = ENetProtocol->new();
	my $fragmentLength;
	if ($peer->{state} != 5 || $channelID >= $peer->{channel_count} || $packet->{data_length} > 1073741824) {
		return -1;
	}
	$fragmentLength = $peer->{mtu} - 4 - 28;
	if (defined($peer->{host}->{checksum})) {
		$fragmentLength -= 4;
	}
	if ($packet->{data_length} > $fragmentLength) {
		my $fragmentCount = ($packet->{data_length} + $fragmentLength - 1) / $fragmentLength;
		my $fragmentNumber;
		my $fragmentOffset;
		my $commandNumber;
		my $startSequenceNumber;
		my $fragments = undef;
		my $fragment;
		if ($fragmentCount > 1048576) {
			return -1;
		}
		if (($packet->{flags} & 9) == 8 && $channel->{outgoing_unreliable_sequence_number} < 65535) {
			$commandNumber = 12;
			$startSequenceNumber = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($channel->{outgoing_unreliable_sequence_number} + 1));
		}
		else {
			$commandNumber = 136;
			$startSequenceNumber = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($channel->{outgoing_reliable_sequence_number} + 1));
		}
		$self->enet_list_clear($fragments);
		$fragmentNumber = 0;
		$fragmentOffset = 0;
		while ($fragmentOffset < $packet->{data_length}) {
			if ($packet->{data_length} - $fragmentOffset < $fragmentLength) {
				$fragmentLength = $packet->{data_length} - $fragmentOffset;
			}
			$fragment = ENetOutgoingCommand->new();
			if (!defined($fragment)) {
				while (!$self->enet_list_empty($fragments)) {
					$fragment = $self->{p}->cast_to_e_net_outgoing_command($self->enet_list_remove($self->enet_list_begin($fragments))->{data});
				}
				return -1;
			}
			$fragment->{fragment_offset} = $fragmentOffset;
			$fragment->{fragment_length} = $self->{p}->int_to_ushort($fragmentLength);
			$fragment->{packet} = $packet;
			$fragment->{command}->{header}->{command} = $commandNumber;
			$fragment->{command}->{header}->{channel_i_d} = $channelID;
			$fragment->{command}->{send_fragment}->{start_sequence_number} = $startSequenceNumber;
			$fragment->{command}->{send_fragment}->{data_length} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($fragmentLength));
			$fragment->{command}->{send_fragment}->{fragment_count} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($fragmentCount);
			$fragment->{command}->{send_fragment}->{fragment_number} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($fragmentNumber);
			$fragment->{command}->{send_fragment}->{total_length} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($packet->{data_length});
			$fragment->{command}->{send_fragment}->{fragment_offset} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($fragmentOffset);
			$self->enet_list_insert($self->enet_list_end($fragments), $fragment);
			$fragmentNumber++;
			$fragmentOffset += $fragmentLength;
		}
		$packet->{reference_count} += $fragmentNumber;
		while (!$self->enet_list_empty($fragments)) {
			$fragment = $self->{p}->cast_to_e_net_outgoing_command($self->enet_list_remove($self->enet_list_begin($fragments)));
			$self->enet_peer_setup_outgoing_command($peer, $fragment);
		}
		return 0;
	}
	$command->{header}->{channel_i_d} = $channelID;
	if (($packet->{flags} & 3) == 2) {
		$command->{header}->{command} = 73;
		$command->{send_unsequenced}->{data_length} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($packet->{data_length}));
	}
	elsif (($packet->{flags} & 1) != 0 || $channel->{outgoing_unreliable_sequence_number} >= 65535) {
		$command->{header}->{command} = 134;
		$command->{send_reliable} = ENetProtocolSendReliable->new();
		$command->{send_reliable}->{data_length} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($packet->{data_length}));
	}
	else {
		$command->{header}->{command} = 7;
		$command->{send_unreliable} = ENetProtocolSendUnreliable->new();
		$command->{send_unreliable}->{data_length} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($packet->{data_length}));
	}
	if (!defined($self->enet_peer_queue_outgoing_command($peer, $command, $packet, 0, $self->{p}->int_to_ushort($packet->{data_length})))) {
		return -1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_peer_setup_outgoing_command($peer, $outgoingCommand)>

=cut

sub enet_peer_setup_outgoing_command($$$) {
	my ($self, $peer, $outgoingCommand) = @_;
	my $channel = undef;
	$peer->{outgoing_data_total} += $self->enet_protocol_command_size($outgoingCommand->{command}->{header}->{command}) + $outgoingCommand->{fragment_length};
	if ($outgoingCommand->{command}->{header}->{channel_i_d} == 255) {
		$peer->{outgoing_reliable_sequence_number}++;
		$outgoingCommand->{reliable_sequence_number} = $peer->{outgoing_reliable_sequence_number};
		$outgoingCommand->{unreliable_sequence_number} = 0;
	}
	else {
		$channel = $peer->{channels}->[$outgoingCommand->{command}->{header}->{channel_i_d}];
		if (($outgoingCommand->{command}->{header}->{command} & 128) != 0) {
			$channel->{outgoing_reliable_sequence_number}++;
			$channel->{outgoing_unreliable_sequence_number} = 0;
			$outgoingCommand->{reliable_sequence_number} = $channel->{outgoing_reliable_sequence_number};
			$outgoingCommand->{unreliable_sequence_number} = 0;
		}
		elsif (($outgoingCommand->{command}->{header}->{command} & 64) != 0) {
			$peer->{outgoing_unsequenced_group}++;
			$outgoingCommand->{reliable_sequence_number} = 0;
			$outgoingCommand->{unreliable_sequence_number} = 0;
		}
		else {
			if ($outgoingCommand->{fragment_offset} == 0) {
				$channel->{outgoing_unreliable_sequence_number}++;
			}
			$outgoingCommand->{reliable_sequence_number} = $channel->{outgoing_reliable_sequence_number};
			$outgoingCommand->{unreliable_sequence_number} = $channel->{outgoing_unreliable_sequence_number};
		}
	}
	$outgoingCommand->{send_attempts} = 0;
	$outgoingCommand->{sent_time} = 0;
	$outgoingCommand->{round_trip_timeout} = 0;
	$outgoingCommand->{round_trip_timeout_limit} = 0;
	$outgoingCommand->{command}->{header}->{reliable_sequence_number} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($outgoingCommand->{reliable_sequence_number});
	given ($outgoingCommand->{command}->{header}->{command} & 15) {
		when (7) {
			$outgoingCommand->{command}->{send_unreliable}->{unreliable_sequence_number} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($outgoingCommand->{unreliable_sequence_number});
		}
		when (9) {
			$outgoingCommand->{command}->{send_unsequenced}->{unsequenced_group} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($peer->{outgoing_unsequenced_group});
		}
	}
	if (($outgoingCommand->{command}->{header}->{command} & 128) != 0) {
		$self->enet_list_insert($self->enet_list_end($peer->{outgoing_reliable_commands}), $outgoingCommand);
	}
	else {
		$self->enet_list_insert($self->enet_list_end($peer->{outgoing_unreliable_commands}), $outgoingCommand);
	}
}

sub enet_peer_throttle($$$) {
	my ($self, $peer, $rtt) = @_;
	if ($peer->{last_round_trip_time} <= $peer->{last_round_trip_time_variance}) {
		$peer->{packet_throttle} = $peer->{packet_throttle_limit};
	}
	elsif ($rtt < $peer->{last_round_trip_time}) {
		$peer->{packet_throttle} += $peer->{packet_throttle_acceleration};
		if ($peer->{packet_throttle} > $peer->{packet_throttle_limit}) {
			$peer->{packet_throttle} = $peer->{packet_throttle_limit};
		}
		return 1;
	}
	elsif ($rtt > $peer->{last_round_trip_time} + 2 * $peer->{last_round_trip_time_variance}) {
		if ($peer->{packet_throttle} > $peer->{packet_throttle_deceleration}) {
			$peer->{packet_throttle} -= $peer->{packet_throttle_deceleration};
		}
		else {
			$peer->{packet_throttle} = 0;
		}
		return -1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_peer_throttle_configure($peer, $interval, $acceleration, $deceleration)>

@defgroup peer ENet peer functions 
Configures throttle parameter for a peer.

Parameters:

=over

=item $peer

peer to configure 

=item $interval

interval, in milliseconds, over which to measure lowest mean RTT; the default value is ENET_PEER_PACKET_THROTTLE_INTERVAL.

=item $acceleration

rate at which to increase the throttle probability as mean RTT declines

=item $deceleration

rate at which to decrease the throttle probability as mean RTT increases

=back

=cut

sub enet_peer_throttle_configure($$$$$) {
	my ($self, $peer, $interval, $acceleration, $deceleration) = @_;
	my $command = ENetProtocol->new();
	$peer->{packet_throttle_interval} = $interval;
	$peer->{packet_throttle_acceleration} = $acceleration;
	$peer->{packet_throttle_deceleration} = $deceleration;
	$command->{header}->{command} = 139;
	$command->{header}->{channel_i_d} = 255;
	$command->{throttle_configure}->{packet_throttle_interval} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($interval);
	$command->{throttle_configure}->{packet_throttle_acceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($acceleration);
	$command->{throttle_configure}->{packet_throttle_deceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($deceleration);
	$self->enet_peer_queue_outgoing_command($peer, $command, undef, 0, 0);
}

=head2 C<$enet-E<gt>enet_peer_timeout($peer, $timeoutLimit, $timeoutMinimum, $timeoutMaximum)>

Sets the timeout parameters for a peer.

Parameters:

=over

=item $peer

the peer to adjust

=item $timeoutLimit

the timeout limit; defaults to ENET_PEER_TIMEOUT_LIMIT if 0

=item $timeoutMinimum

the timeout minimum; defaults to ENET_PEER_TIMEOUT_MINIMUM if 0

=item $timeoutMaximum

the timeout maximum; defaults to ENET_PEER_TIMEOUT_MAXIMUM if 0

=back

=cut

sub enet_peer_timeout($$$$$) {
	my ($self, $peer, $timeoutLimit, $timeoutMinimum, $timeoutMaximum) = @_;
	$peer->{timeout_limit} = $timeoutLimit != 0 ? $timeoutLimit : 32;
	$peer->{timeout_minimum} = $timeoutMinimum != 0 ? $timeoutMinimum : 5000;
	$peer->{timeout_maximum} = $timeoutMaximum != 0 ? $timeoutMaximum : 30000;
}

=head2 C<$enet-E<gt>enet_protocol_change_state($host, $peer, $state)>

=cut

sub enet_protocol_change_state($$$$) {
	my ($self, $host, $peer, $state) = @_;
	if ($state == 5 || $state == 6) {
		$self->enet_peer_on_connect($peer);
	}
	else {
		$self->enet_peer_on_disconnect($peer);
	}
	$peer->{state} = $state;
}

=head2 C<$enet-E<gt>enet_protocol_check_timeouts($host, $peer, $event_)>

=cut

sub enet_protocol_check_timeouts($$$$) {
	my ($self, $host, $peer, $event_) = @_;
	my $outgoingCommand = undef;
	my $currentCommand;
	my $insertPosition;
	$currentCommand = $self->enet_list_begin($peer->{sent_reliable_commands});
	$insertPosition = $self->enet_list_begin($peer->{outgoing_reliable_commands});
	while ($currentCommand != $self->enet_list_end($peer->{sent_reliable_commands})) {
		$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($currentCommand);
		$currentCommand = $self->enet_list_next($currentCommand);
		if ($self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $outgoingCommand->{sent_time}) < $outgoingCommand->{round_trip_timeout}) {
			next;
		}
		if ($peer->{earliest_timeout} == 0 || $self->e_n_e_t__t_i_m_e__l_e_s_s($outgoingCommand->{sent_time}, $peer->{earliest_timeout})) {
			$peer->{earliest_timeout} = $outgoingCommand->{sent_time};
		}
		if ($peer->{earliest_timeout} != 0 && ($self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $peer->{earliest_timeout}) >= $peer->{timeout_maximum} || $outgoingCommand->{round_trip_timeout} >= $outgoingCommand->{round_trip_timeout_limit} && $self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $peer->{earliest_timeout}) >= $peer->{timeout_minimum})) {
			$self->enet_protocol_notify_disconnect($host, $peer, $event_);
			return 1;
		}
		if (defined($outgoingCommand->{packet})) {
			$peer->{reliable_data_in_transit} -= $outgoingCommand->{fragment_length};
		}
		$peer->{packets_lost}++;
		$outgoingCommand->{round_trip_timeout} *= 2;
		$self->enet_list_insert($insertPosition, $self->enet_list_remove($outgoingCommand->outgoing_command_list()));
		if ($currentCommand == $self->enet_list_begin($peer->{sent_reliable_commands}) && !$self->enet_list_empty($peer->{sent_reliable_commands})) {
			$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($currentCommand);
			$peer->{next_timeout} = $outgoingCommand->{sent_time} + $outgoingCommand->{round_trip_timeout};
		}
	}
	return 0;
}

sub enet_protocol_command_size($$) {
	my ($self, $commandNumber) = @_;
	return $self->{command_sizes}->[$commandNumber & 15];
}

=head2 C<$enet-E<gt>enet_protocol_dispatch_incoming_commands($host, $event_)>

=cut

sub enet_protocol_dispatch_incoming_commands($$$) {
	my ($self, $host, $event_) = @_;
	while (!$self->enet_list_empty($host->{dispatch_queue})) {
		my $peer = $self->{p}->cast_to_e_net_peer($self->enet_list_remove($self->enet_list_begin($host->{dispatch_queue})));
		$peer->{needs_dispatch} = 0;
		given ($peer->{state}) {
			when ([ 3, 4 ]) {
				$self->enet_protocol_change_state($host, $peer, 5);
				$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T();
				$event_->{peer} = $peer;
				$event_->{data} = $peer->{event_data};
				return 1;
			}
			when (9) {
				$host->{recalculate_bandwidth_limits} = 1;
				$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T();
				$event_->{peer} = $peer;
				$event_->{data} = $peer->{event_data};
				$self->enet_peer_reset($peer);
				return 1;
			}
			when (5) {
				if ($self->enet_list_empty($peer->{dispatched_commands})) {
					next;
				}
				my $b = Byte->new();
				$b->{value} = $event_->{channel_i_d};
				$event_->{packet} = $self->enet_peer_receive($peer, $b);
				$event_->{channel_i_d} = $b->{value};
				if (!defined($event_->{packet})) {
					next;
				}
				$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E();
				$event_->{peer} = $peer;
				if (!$self->enet_list_empty($peer->{dispatched_commands})) {
					$peer->{needs_dispatch} = 1;
					$self->enet_list_insert($self->enet_list_end($host->{dispatch_queue}), $peer->dispatch_list());
				}
				return 1;
			}
		}
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_dispatch_state($host, $peer, $state)>

=cut

sub enet_protocol_dispatch_state($$$$) {
	my ($self, $host, $peer, $state) = @_;
	$self->enet_protocol_change_state($host, $peer, $state);
	if ($peer->{needs_dispatch} == 0) {
		$self->enet_list_insert($self->enet_list_end($host->{dispatch_queue}), $peer->dispatch_list());
		$peer->{needs_dispatch} = 1;
	}
}

=head2 C<$enet-E<gt>enet_protocol_handle_acknowledge($host, $event_, $peer, $command)>

=cut

sub enet_protocol_handle_acknowledge($$$$$) {
	my ($self, $host, $event_, $peer, $command) = @_;
	my $roundTripTime;
	my $receivedSentTime;
	my $receivedReliableSequenceNumber;
	my $commandNumber;
	if ($peer->{state} == 0 || $peer->{state} == 9) {
		return 0;
	}
	$receivedSentTime = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{acknowledge}->{received_sent_time});
	$receivedSentTime |= $host->{service_time} & -65536;
	if (($receivedSentTime & 32768) > ($host->{service_time} & 32768)) {
		$receivedSentTime -= 65536;
	}
	if ($self->e_n_e_t__t_i_m_e__l_e_s_s($host->{service_time}, $receivedSentTime)) {
		return 0;
	}
	$peer->{last_receive_time} = $host->{service_time};
	$peer->{earliest_timeout} = 0;
	$roundTripTime = $self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $receivedSentTime);
	$self->enet_peer_throttle($peer, $roundTripTime);
	$peer->{round_trip_time_variance} -= $peer->{round_trip_time_variance} / 4;
	if ($roundTripTime >= $peer->{round_trip_time}) {
		$peer->{round_trip_time} += ($roundTripTime - $peer->{round_trip_time}) / 8;
		$peer->{round_trip_time_variance} += ($roundTripTime - $peer->{round_trip_time}) / 4;
	}
	else {
		$peer->{round_trip_time} -= ($peer->{round_trip_time} - $roundTripTime) / 8;
		$peer->{round_trip_time_variance} += ($peer->{round_trip_time} - $roundTripTime) / 4;
	}
	if ($peer->{round_trip_time} < $peer->{lowest_round_trip_time}) {
		$peer->{lowest_round_trip_time} = $peer->{round_trip_time};
	}
	if ($peer->{round_trip_time_variance} > $peer->{highest_round_trip_time_variance}) {
		$peer->{highest_round_trip_time_variance} = $peer->{round_trip_time_variance};
	}
	if ($peer->{packet_throttle_epoch} == 0 || $self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $peer->{packet_throttle_epoch}) >= $peer->{packet_throttle_interval}) {
		$peer->{last_round_trip_time} = $peer->{lowest_round_trip_time};
		$peer->{last_round_trip_time_variance} = $peer->{highest_round_trip_time_variance};
		$peer->{lowest_round_trip_time} = $peer->{round_trip_time};
		$peer->{highest_round_trip_time_variance} = $peer->{round_trip_time_variance};
		$peer->{packet_throttle_epoch} = $host->{service_time};
	}
	$receivedReliableSequenceNumber = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{acknowledge}->{received_reliable_sequence_number});
	$commandNumber = $self->enet_protocol_remove_sent_reliable_command($peer, $self->{p}->int_to_ushort($receivedReliableSequenceNumber), $command->{header}->{channel_i_d});
	given ($peer->{state}) {
		when (2) {
			if ($commandNumber != 3) {
				return -1;
			}
			$self->enet_protocol_notify_connect($host, $peer, $event_);
		}
		when (7) {
			if ($commandNumber != 4) {
				return -1;
			}
			$self->enet_protocol_notify_disconnect($host, $peer, $event_);
		}
		when (6) {
			if ($self->enet_list_empty($peer->{outgoing_reliable_commands}) && $self->enet_list_empty($peer->{outgoing_unreliable_commands}) && $self->enet_list_empty($peer->{sent_reliable_commands})) {
				$self->enet_peer_disconnect($peer, $peer->{event_data});
			}
		}
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_bandwidth_limit($host, $peer, $command)>

=cut

sub enet_protocol_handle_bandwidth_limit($$$$) {
	my ($self, $host, $peer, $command) = @_;
	if ($peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	if ($peer->{incoming_bandwidth} != 0) {
		$host->{bandwidth_limited_peers}--;
	}
	$peer->{incoming_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{bandwidth_limit}->{incoming_bandwidth});
	$peer->{outgoing_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{bandwidth_limit}->{outgoing_bandwidth});
	if ($peer->{incoming_bandwidth} != 0) {
		$host->{bandwidth_limited_peers}++;
	}
	if ($peer->{incoming_bandwidth} == 0 && $host->{outgoing_bandwidth} == 0) {
		$peer->{window_size} = 32768;
	}
	else {
		$peer->{window_size} = $self->e_n_e_t__m_i_n($peer->{incoming_bandwidth}, $host->{outgoing_bandwidth}) / 65536 * 4096;
	}
	if ($peer->{window_size} < 4096) {
		$peer->{window_size} = 4096;
	}
	elsif ($peer->{window_size} > 32768) {
		$peer->{window_size} = 32768;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_connect($host, $header, $command)>

=cut

sub enet_protocol_handle_connect($$$$) {
	my ($self, $host, $header, $command) = @_;
	my $incomingSessionID;
	my $outgoingSessionID;
	my $mtu;
	my $windowSize;
	my $channel;
	my $channelCount;
	my $currentPeer = ENetPeer->new();
	my $verifyCommand = ENetProtocol->new();
	$channelCount = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{channel_count});
	if ($channelCount < 1 || $channelCount > 255) {
		return undef;
	}
	my $i;
	for ($i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		if ($currentPeer->{state} != 0 && $currentPeer->{address}->{host} == $host->{received_address}->{host} && $currentPeer->{address}->{port} == $host->{received_address}->{port} && $currentPeer->{connect_i_d} == $command->{connect}->{connect_i_d}) {
			return undef;
		}
	}
	for ($i = 0; $i < $host->{peer_count}; $i++) {
		$currentPeer = $host->{peers}->[$i];
		if ($currentPeer->{state} == 0) {
			last;
		}
	}
	if ($i >= $host->{peer_count}) {
		return undef;
	}
	if ($channelCount > $host->{channel_limit}) {
		$channelCount = $host->{channel_limit};
	}
	$currentPeer->{channels} = [];
	for (my $k = 0; $k < $channelCount; $k++) {
		$currentPeer->{channels}->[$k] = ENetChannel->new();
	}
	if (!defined($currentPeer->{channels})) {
		return undef;
	}
	$currentPeer->{channel_count} = $channelCount;
	$currentPeer->{state} = 2;
	$currentPeer->{connect_i_d} = $command->{connect}->{connect_i_d};
	$currentPeer->{address} = $host->{received_address};
	$currentPeer->{outgoing_peer_i_d} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{connect}->{outgoing_peer_i_d});
	$currentPeer->{incoming_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{incoming_bandwidth});
	$currentPeer->{outgoing_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{outgoing_bandwidth});
	$currentPeer->{packet_throttle_interval} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{packet_throttle_interval});
	$currentPeer->{packet_throttle_acceleration} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{packet_throttle_acceleration});
	$currentPeer->{packet_throttle_deceleration} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{packet_throttle_deceleration});
	$currentPeer->{event_data} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{data});
	$incomingSessionID = $command->{connect}->{incoming_session_i_d} == 255 ? $currentPeer->{outgoing_session_i_d} : $command->{connect}->{incoming_session_i_d};
	$incomingSessionID = ENet::to_byte($incomingSessionID + 1 & 3);
	if ($incomingSessionID == $currentPeer->{outgoing_session_i_d}) {
		$incomingSessionID = ENet::to_byte($incomingSessionID + 1 & 3);
	}
	$currentPeer->{outgoing_session_i_d} = $incomingSessionID;
	$outgoingSessionID = $command->{connect}->{outgoing_session_i_d} == 255 ? $currentPeer->{incoming_session_i_d} : $command->{connect}->{outgoing_session_i_d};
	$outgoingSessionID = ENet::to_byte($outgoingSessionID + 1 & 3);
	if ($outgoingSessionID == $currentPeer->{incoming_session_i_d}) {
		$outgoingSessionID = ENet::to_byte($outgoingSessionID + 1 & 3);
	}
	$currentPeer->{incoming_session_i_d} = $outgoingSessionID;
	for ($i = 0; $i < $currentPeer->{channel_count}; $i++) {
		$channel = $currentPeer->{channels}->[$i];
		$channel->{outgoing_reliable_sequence_number} = 0;
		$channel->{outgoing_unreliable_sequence_number} = 0;
		$channel->{incoming_reliable_sequence_number} = 0;
		$channel->{incoming_unreliable_sequence_number} = 0;
		$self->enet_list_clear($channel->{incoming_reliable_commands});
		$self->enet_list_clear($channel->{incoming_unreliable_commands});
		$channel->{used_reliable_windows} = 0;
		for (my $k = 0; $k < 16; $k++) {
			$channel->{reliable_windows}->[$k] = 0;
		}
	}
	$mtu = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{mtu});
	if ($mtu < 576) {
		$mtu = 576;
	}
	elsif ($mtu > 4096) {
		$mtu = 4096;
	}
	$currentPeer->{mtu} = $mtu;
	if ($host->{outgoing_bandwidth} == 0 && $currentPeer->{incoming_bandwidth} == 0) {
		$currentPeer->{window_size} = 32768;
	}
	elsif ($host->{outgoing_bandwidth} == 0 || $currentPeer->{incoming_bandwidth} == 0) {
		$currentPeer->{window_size} = $self->e_n_e_t__m_a_x($host->{outgoing_bandwidth}, $currentPeer->{incoming_bandwidth}) / 65536 * 4096;
	}
	else {
		$currentPeer->{window_size} = $self->e_n_e_t__m_i_n($host->{outgoing_bandwidth}, $currentPeer->{incoming_bandwidth}) / 65536 * 4096;
	}
	if ($currentPeer->{window_size} < 4096) {
		$currentPeer->{window_size} = 4096;
	}
	elsif ($currentPeer->{window_size} > 32768) {
		$currentPeer->{window_size} = 32768;
	}
	if ($host->{incoming_bandwidth} == 0) {
		$windowSize = 32768;
	}
	else {
		$windowSize = $host->{incoming_bandwidth} / 65536 * 4096;
	}
	if ($windowSize > $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{window_size})) {
		$windowSize = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{connect}->{window_size});
	}
	if ($windowSize < 4096) {
		$windowSize = 4096;
	}
	elsif ($windowSize > 32768) {
		$windowSize = 32768;
	}
	$verifyCommand->{header} = ENetProtocolCommandHeader->new();
	$verifyCommand->{header}->{command} = 131;
	$verifyCommand->{header}->{channel_i_d} = 255;
	$verifyCommand->{verify_connect} = ENetProtocolVerifyConnect->new();
	$verifyCommand->{verify_connect}->{outgoing_peer_i_d} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_16($currentPeer->{incoming_peer_i_d});
	$verifyCommand->{verify_connect}->{incoming_session_i_d} = $incomingSessionID;
	$verifyCommand->{verify_connect}->{outgoing_session_i_d} = $outgoingSessionID;
	$verifyCommand->{verify_connect}->{mtu} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{mtu});
	$verifyCommand->{verify_connect}->{window_size} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($windowSize);
	$verifyCommand->{verify_connect}->{channel_count} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($channelCount);
	$verifyCommand->{verify_connect}->{incoming_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($host->{incoming_bandwidth});
	$verifyCommand->{verify_connect}->{outgoing_bandwidth} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($host->{outgoing_bandwidth});
	$verifyCommand->{verify_connect}->{packet_throttle_interval} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_interval});
	$verifyCommand->{verify_connect}->{packet_throttle_acceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_acceleration});
	$verifyCommand->{verify_connect}->{packet_throttle_deceleration} = $self->{p}->e_n_e_t__h_o_s_t__t_o__n_e_t_32($currentPeer->{packet_throttle_deceleration});
	$verifyCommand->{verify_connect}->{connect_i_d} = $currentPeer->{connect_i_d};
	$self->enet_peer_queue_outgoing_command($currentPeer, $verifyCommand, undef, 0, 0);
	return $currentPeer;
}

=head2 C<$enet-E<gt>enet_protocol_handle_disconnect($host, $peer, $command)>

=cut

sub enet_protocol_handle_disconnect($$$$) {
	my ($self, $host, $peer, $command) = @_;
	if ($peer->{state} == 0 || $peer->{state} == 9 || $peer->{state} == 8) {
		return 0;
	}
	$self->enet_peer_reset_queues($peer);
	if ($peer->{state} == 4 || $peer->{state} == 7) {
		$self->enet_protocol_dispatch_state($host, $peer, 9);
	}
	elsif ($peer->{state} != 5 && $peer->{state} != 6) {
		if ($peer->{state} == 3) {
			$host->{recalculate_bandwidth_limits} = 1;
		}
		$self->enet_peer_reset($peer);
	}
	elsif (($command->{header}->{command} & 128) != 0) {
		$self->enet_protocol_change_state($host, $peer, 8);
	}
	else {
		$self->enet_protocol_dispatch_state($host, $peer, 9);
	}
	if ($peer->{state} != 0) {
		$peer->{event_data} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{disconnect}->{data});
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_incoming_commands($host, $event_)>

=cut

sub enet_protocol_handle_incoming_commands($$$) {
	my ($self, $host, $event_) = @_;
	my $header;
	my $command = undef;
	my $peer;
	my $currentData = undef;
	my $headerSize = 0;
	my $peerID;
	my $flags;
	my $sessionID;
	my $currentDataI = [];
	$currentDataI->[0] = 0;
	$header = $self->deserialize($host->{received_data});
	$peerID = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($header->{peer_i_d});
	$sessionID = ($peerID & 12288) >> 12;
	$flags = $self->{p}->int_to_ushort($peerID & 49152);
	$peerID &= $self->{p}->int_to_ushort(~61440);
	$headerSize = ($flags & 32768) != 0 ? 4 : 2;
	if (defined($host->{checksum})) {
		$headerSize += 4;
	}
	if ($peerID == 4095) {
		$peer = undef;
	}
	elsif ($peerID >= $host->{peer_count}) {
		return 0;
	}
	else {
		$peer = $host->{peers}->[$peerID];
		if ($peer->{state} == 0 || $peer->{state} == 9 || ($host->{received_address}->{host} != $peer->{address}->{host} || $host->{received_address}->{port} != $peer->{address}->{port}) && $peer->{address}->{host} != -1 || $peer->{outgoing_peer_i_d} < 4095 && $sessionID != $peer->{incoming_session_i_d}) {
			return 0;
		}
	}
	if (($flags & 16384) != 0) {
		my $originalSize = 0;
		if (!defined($host->{compressor})) {
			return 0;
		}
		for (my $i = 0; $i < $headerSize; $i++) {
		}
		$host->{received_data} = $host->{packet_data}->[1];
		$host->{received_data_length} = $headerSize + $originalSize;
	}
	if (defined($host->{checksum})) {
		my $checksum = 0;
		my $desiredChecksum = $checksum;
		my $buffer = ENetBuffer->new();
		$checksum = defined($peer) ? $peer->{connect_i_d} : 0;
		$buffer->{data} = $host->{received_data};
		$buffer->{data_length} = $host->{received_data_length};
		if ($host->{checksum}->run($buffer, 1) != $desiredChecksum) {
			return 0;
		}
	}
	if (defined($peer)) {
		$peer->{address}->{host} = $host->{received_address}->{host};
		$peer->{address}->{port} = $host->{received_address}->{port};
		$peer->{incoming_data_total} += $host->{received_data_length};
	}
	$currentDataI->[0] += $headerSize;
	my $test = 0;
	while ($currentDataI->[0] < $host->{received_data_length}) {
		my $commandNumber;
		my $commandSize;
		if ($test > 0) {
		}
		$test++;
		if ($currentDataI->[0] + 4 > $host->{received_data_length}) {
			last;
		}
		$command = $self->deserialize_protocol_command_header($host->{received_data}, $currentDataI->[0]);
		$commandNumber = ENet::to_byte($command->{header}->{command} & 15);
		if ($commandNumber == 0) {
		}
		if ($commandNumber >= 13) {
			last;
		}
		$commandSize = $self->{command_sizes}->[$commandNumber];
		if ($commandSize == 0 || $currentDataI->[0] + $commandSize > $host->{received_data_length}) {
			last;
		}
		$self->deserialize_protocol_command_command($host->{received_data}, $currentDataI->[0], $commandNumber, $command);
		$currentDataI->[0] += $commandSize;
		if (!defined($peer) && $commandNumber != 2) {
			last;
		}
		$command->{header}->{reliable_sequence_number} = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{header}->{reliable_sequence_number});
		if ($self->{test1} == 1) {
		}
		if ($command->{header}->{reliable_sequence_number} == 1) {
			$self->{test1}++;
		}
		given ($commandNumber) {
			when (1) {
				if ($self->enet_protocol_handle_acknowledge($host, $event_, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (2) {
				if (defined($peer)) {
					return $self->command_error($event_);
				}
				$peer = $self->enet_protocol_handle_connect($host, $header, $command);
				if (!defined($peer)) {
					return $self->command_error($event_);
				}
			}
			when (3) {
				if ($self->enet_protocol_handle_verify_connect($host, $event_, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (4) {
				if ($self->enet_protocol_handle_disconnect($host, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (5) {
				if ($self->enet_protocol_handle_ping($host, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (6) {
				if ($self->enet_protocol_handle_send_reliable($host, $peer, $command, $host->{received_data}, $currentDataI) != 0) {
					return $self->command_error($event_);
				}
			}
			when (7) {
				if ($self->enet_protocol_handle_send_unreliable($host, $peer, $command, $host->{received_data}, $currentDataI) != 0) {
					return $self->command_error($event_);
				}
			}
			when (9) {
				if ($self->enet_protocol_handle_send_unsequenced($host, $peer, $command, $currentData) != 0) {
					return $self->command_error($event_);
				}
			}
			when (8) {
				if ($self->enet_protocol_handle_send_fragment($host, $peer, $command, $host->{received_data}, $currentDataI) != 0) {
					return $self->command_error($event_);
				}
			}
			when (10) {
				if ($self->enet_protocol_handle_bandwidth_limit($host, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (11) {
				if ($self->enet_protocol_handle_throttle_configure($host, $peer, $command) != 0) {
					return $self->command_error($event_);
				}
			}
			when (12) {
				if ($self->enet_protocol_handle_send_unreliable_fragment($host, $peer, $command, $currentData) != 0) {
					return $self->command_error($event_);
				}
			}
			default {
				return $self->command_error($event_);
			}
		}
		if (defined($peer) && ($command->{header}->{command} & 128) != 0) {
			my $sentTime;
			if (($flags & 32768) == 0) {
				last;
			}
			$sentTime = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($header->{sent_time});
			given ($peer->{state}) {
				when ([ 7, 2, 0, 9 ]) {
				}
				when (8) {
					if (($command->{header}->{command} & 15) == 4) {
						$self->enet_peer_queue_acknowledgement($peer, $command, $sentTime);
					}
				}
				default {
					$self->enet_peer_queue_acknowledgement($peer, $command, $sentTime);
				}
			}
		}
	}
	if (defined($event_) && $event_->{type} != ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E()) {
		return 1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_ping($host, $peer, $command)>

=cut

sub enet_protocol_handle_ping($$$$) {
	my ($self, $host, $peer, $command) = @_;
	if ($peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_send_fragment($host, $peer, $command, \@currentData, \@currentDataI)>

=cut

sub enet_protocol_handle_send_fragment($$$$$$) {
	my ($self, $host, $peer, $command, $currentData, $currentDataI) = @_;
	my $fragmentNumber;
	my $fragmentCount;
	my $fragmentOffset;
	my $fragmentLength;
	my $startSequenceNumber;
	my $totalLength;
	my $channel;
	my $startWindow;
	my $currentWindow;
	my $currentCommand;
	my $startCommand = undef;
	if ($command->{header}->{channel_i_d} >= $peer->{channel_count} || $peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	$fragmentLength = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_fragment}->{data_length});
	$currentDataI->[0] += $fragmentLength;
	if ($fragmentLength > 1073741824 || $currentDataI->[0] < 0 || $currentDataI->[0] > $host->{received_data_length}) {
		return -1;
	}
	$channel = $peer->{channels}->[$command->{header}->{channel_i_d}];
	$startSequenceNumber = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_fragment}->{start_sequence_number});
	$startWindow = $self->{p}->int_to_ushort($startSequenceNumber / 4096);
	$currentWindow = $self->{p}->int_to_ushort($channel->{incoming_reliable_sequence_number} / 4096);
	if ($startSequenceNumber < $channel->{incoming_reliable_sequence_number}) {
		$startWindow += 16;
	}
	if ($startWindow < $currentWindow || $startWindow >= $currentWindow + 8 - 1) {
		return 0;
	}
	$fragmentNumber = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_number});
	$fragmentCount = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_count});
	$fragmentOffset = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_offset});
	$totalLength = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{total_length});
	if ($fragmentCount > 1048576 || $fragmentNumber >= $fragmentCount || $totalLength > 1073741824 || $fragmentOffset >= $totalLength || $fragmentLength > $totalLength - $fragmentOffset) {
		return -1;
	}
	for ($currentCommand = $self->enet_list_previous($self->enet_list_end($channel->{incoming_reliable_commands})); $currentCommand != $self->enet_list_end($channel->{incoming_reliable_commands}); $currentCommand = $self->enet_list_previous($currentCommand)) {
		my $incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
		if ($startSequenceNumber >= $channel->{incoming_reliable_sequence_number}) {
			if ($incomingCommand->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
				next;
			}
		}
		elsif ($incomingCommand->{reliable_sequence_number} >= $channel->{incoming_reliable_sequence_number}) {
			last;
		}
		if ($incomingCommand->{reliable_sequence_number} <= $startSequenceNumber) {
			if ($incomingCommand->{reliable_sequence_number} < $startSequenceNumber) {
				last;
			}
			if (($incomingCommand->{command}->{header}->{command} & 15) != 8 || $totalLength != $incomingCommand->{packet}->{data_length} || $fragmentCount != $incomingCommand->{fragment_count}) {
				return -1;
			}
			$startCommand = $incomingCommand;
			last;
		}
	}
	if (!defined($startCommand)) {
		my $hostCommand = $command;
		my $packet = $self->enet_packet_create(undef, $totalLength, 1);
		if (!defined($packet)) {
			return -1;
		}
		$hostCommand->{header}->{reliable_sequence_number} = $self->{p}->int_to_ushort($startSequenceNumber);
		$startCommand = $self->enet_peer_queue_incoming_command($peer, $hostCommand, $packet, $fragmentCount);
		if (!defined($startCommand)) {
			return -1;
		}
	}
	if (($startCommand->{fragments}->[$fragmentNumber / 32] & 1 << $fragmentNumber % 32) == 0) {
		$startCommand->{fragments_remaining}--;
		$startCommand->{fragments}->[$fragmentNumber / 32] |= 1 << $fragmentNumber % 32;
		if ($fragmentOffset + $fragmentLength > $startCommand->{packet}->{data_length}) {
			$fragmentLength = $startCommand->{packet}->{data_length} - $fragmentOffset;
		}
		my $data = [];
		$self->serialize_command($data, $command);
		for (my $i = 0; $i < $fragmentLength; $i++) {
			$startCommand->{packet}->{data}->[$i + $fragmentOffset] = $data->[$i + 28];
		}
		if ($startCommand->{fragments_remaining} <= 0) {
			$self->enet_peer_dispatch_incoming_reliable_commands($peer, $channel);
		}
	}
	return 0;
}

sub enet_protocol_handle_send_reliable($$$$$$) {
	my ($self, $host, $peer, $command, $currentData, $currentDataI) = @_;
	my $packet;
	my $dataLength;
	if ($command->{header}->{channel_i_d} >= $peer->{channel_count} || $peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	$dataLength = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_reliable}->{data_length});
	if ($dataLength > 1073741824 || $currentDataI->[0] < 0 || $currentDataI->[0] > $host->{received_data_length}) {
		return -1;
	}
	$command->{data} = [];
	for (my $i = 0; $i < $dataLength; $i++) {
		$command->{data}->[$i] = $currentData->[$currentDataI->[0] + $i];
	}
	$currentDataI->[0] += $dataLength;
	$packet = $self->enet_packet_create($command->{data}, $dataLength, 1);
	if (!defined($packet) || !defined($self->enet_peer_queue_incoming_command($peer, $command, $packet, 0))) {
		return -1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_send_unreliable($host, $peer, $command, \@currentData, \@currentDataI)>

=cut

sub enet_protocol_handle_send_unreliable($$$$$$) {
	my ($self, $host, $peer, $command, $currentData, $currentDataI) = @_;
	my $packet;
	my $dataLength;
	if ($command->{header}->{channel_i_d} >= $peer->{channel_count} || $peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	$dataLength = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_unreliable}->{data_length});
	$currentDataI->[0] += $dataLength;
	if ($dataLength > 1073741824 || $currentDataI->[0] < 0 || $currentDataI->[0] > $host->{received_data_length}) {
		return -1;
	}
	$command->{data} = [];
	for (my $i = 0; $i < $dataLength; $i++) {
		$command->{data}->[$i] = $currentData->[$currentDataI->[0] - $dataLength + $i];
	}
	$packet = $self->enet_packet_create($command->{data}, $dataLength, 0);
	if (!defined($packet) || !defined($self->enet_peer_queue_incoming_command($peer, $command, $packet, 0))) {
		return -1;
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_send_unreliable_fragment($host, $peer, $command, \@currentData)>

=cut

sub enet_protocol_handle_send_unreliable_fragment($$$$$) {
	my ($self, $host, $peer, $command, $currentData) = @_;
	my $fragmentNumber;
	my $fragmentCount;
	my $fragmentOffset;
	my $fragmentLength;
	my $reliableSequenceNumber;
	my $startSequenceNumber;
	my $totalLength;
	my $reliableWindow;
	my $currentWindow;
	my $channel;
	my $currentCommand;
	my $startCommand = undef;
	if ($command->{header}->{channel_i_d} >= $peer->{channel_count} || $peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	$fragmentLength = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_fragment}->{data_length});
	my $currentDataI = 0;
	$currentDataI += $fragmentLength;
	if ($fragmentLength > 1073741824 || $currentDataI < 0 || $currentDataI > $host->{received_data_length}) {
		return -1;
	}
	$channel = $peer->{channels}->[$command->{header}->{channel_i_d}];
	$reliableSequenceNumber = $command->{header}->{reliable_sequence_number};
	$startSequenceNumber = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{send_fragment}->{start_sequence_number});
	$reliableWindow = $self->{p}->int_to_ushort($reliableSequenceNumber / 4096);
	$currentWindow = $self->{p}->int_to_ushort($channel->{incoming_reliable_sequence_number} / 4096);
	if ($reliableSequenceNumber < $channel->{incoming_reliable_sequence_number}) {
		$reliableWindow += 16;
	}
	if ($reliableWindow < $currentWindow || $reliableWindow >= $currentWindow + 8 - 1) {
		return 0;
	}
	if ($reliableSequenceNumber == $channel->{incoming_reliable_sequence_number} && $startSequenceNumber <= $channel->{incoming_unreliable_sequence_number}) {
		return 0;
	}
	$fragmentNumber = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_number});
	$fragmentCount = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_count});
	$fragmentOffset = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{fragment_offset});
	$totalLength = $self->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{send_fragment}->{total_length});
	if ($fragmentCount > 1048576 || $fragmentNumber >= $fragmentCount || $totalLength > 1073741824 || $fragmentOffset >= $totalLength || $fragmentLength > $totalLength - $fragmentOffset) {
		return -1;
	}
	for ($currentCommand = $self->enet_list_previous($self->enet_list_end($channel->{incoming_unreliable_commands})); $currentCommand != $self->enet_list_end($channel->{incoming_unreliable_commands}); $currentCommand = $self->enet_list_previous($currentCommand)) {
		my $incomingCommand = $self->{p}->cast_to_e_net_incoming_command($currentCommand);
		if ($reliableSequenceNumber >= $channel->{incoming_reliable_sequence_number}) {
			if ($incomingCommand->{reliable_sequence_number} < $channel->{incoming_reliable_sequence_number}) {
				next;
			}
		}
		elsif ($incomingCommand->{reliable_sequence_number} >= $channel->{incoming_reliable_sequence_number}) {
			last;
		}
		if ($incomingCommand->{reliable_sequence_number} < $reliableSequenceNumber) {
			last;
		}
		if ($incomingCommand->{reliable_sequence_number} > $reliableSequenceNumber) {
			next;
		}
		if ($incomingCommand->{unreliable_sequence_number} <= $startSequenceNumber) {
			if ($incomingCommand->{unreliable_sequence_number} < $startSequenceNumber) {
				last;
			}
			if (($incomingCommand->{command}->{header}->{command} & 15) != 12 || $totalLength != $incomingCommand->{packet}->{data_length} || $fragmentCount != $incomingCommand->{fragment_count}) {
				return -1;
			}
			$startCommand = $incomingCommand;
			last;
		}
	}
	if (!defined($startCommand)) {
		my $packet = $self->enet_packet_create(undef, $totalLength, 8);
		if (!defined($packet)) {
			return -1;
		}
		$startCommand = $self->enet_peer_queue_incoming_command($peer, $command, $packet, $fragmentCount);
		if (!defined($startCommand)) {
			return -1;
		}
	}
	if (($startCommand->{fragments}->[$fragmentNumber / 32] & 1 << $fragmentNumber % 32) == 0) {
		$startCommand->{fragments_remaining}--;
		$startCommand->{fragments}->[$fragmentNumber / 32] |= 1 << $fragmentNumber % 32;
		if ($fragmentOffset + $fragmentLength > $startCommand->{packet}->{data_length}) {
			$fragmentLength = $startCommand->{packet}->{data_length} - $fragmentOffset;
		}
		for (my $i = 0; $i < $fragmentLength; $i++) {
			$startCommand->{packet}->{data}->[$fragmentOffset + $i] = $command->{data}->[$i];
		}
		if ($startCommand->{fragments_remaining} <= 0) {
			$self->enet_peer_dispatch_incoming_unreliable_commands($peer, $channel);
		}
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_send_unsequenced($host, $peer, $command, \@currentData)>

=cut

sub enet_protocol_handle_send_unsequenced($$$$$) {
	my ($self, $host, $peer, $command, $currentData) = @_;
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_throttle_configure($host, $peer, $command)>

=cut

sub enet_protocol_handle_throttle_configure($$$$) {
	my ($self, $host, $peer, $command) = @_;
	if ($peer->{state} != 5 && $peer->{state} != 6) {
		return -1;
	}
	$peer->{packet_throttle_interval} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{throttle_configure}->{packet_throttle_interval});
	$peer->{packet_throttle_acceleration} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{throttle_configure}->{packet_throttle_acceleration});
	$peer->{packet_throttle_deceleration} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{throttle_configure}->{packet_throttle_deceleration});
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_handle_verify_connect($host, $event_, $peer, $command)>

=cut

sub enet_protocol_handle_verify_connect($$$$$) {
	my ($self, $host, $event_, $peer, $command) = @_;
	my $mtu;
	my $windowSize;
	my $channelCount;
	if ($peer->{state} != 1) {
		return 0;
	}
	$channelCount = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{channel_count});
	if ($channelCount < 1 || $channelCount > 255 || $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{packet_throttle_interval}) != $peer->{packet_throttle_interval} || $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{packet_throttle_acceleration}) != $peer->{packet_throttle_acceleration} || $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{packet_throttle_deceleration}) != $peer->{packet_throttle_deceleration} || $command->{verify_connect}->{connect_i_d} != $peer->{connect_i_d}) {
		$peer->{event_data} = 0;
		$self->enet_protocol_dispatch_state($host, $peer, 9);
		return -1;
	}
	$self->enet_protocol_remove_sent_reliable_command($peer, 1, 255);
	if ($channelCount < $peer->{channel_count}) {
		$peer->{channel_count} = $channelCount;
	}
	$peer->{outgoing_peer_i_d} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_16($command->{verify_connect}->{outgoing_peer_i_d});
	$peer->{incoming_session_i_d} = $command->{verify_connect}->{incoming_session_i_d};
	$peer->{outgoing_session_i_d} = $command->{verify_connect}->{outgoing_session_i_d};
	$mtu = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{mtu});
	if ($mtu < 576) {
		$mtu = 576;
	}
	elsif ($mtu > 4096) {
		$mtu = 4096;
	}
	if ($mtu < $peer->{mtu}) {
		$peer->{mtu} = $mtu;
	}
	$windowSize = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{window_size});
	if ($windowSize < 4096) {
		$windowSize = 4096;
	}
	if ($windowSize > 32768) {
		$windowSize = 32768;
	}
	if ($windowSize < $peer->{window_size}) {
		$peer->{window_size} = $windowSize;
	}
	$peer->{incoming_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{incoming_bandwidth});
	$peer->{outgoing_bandwidth} = $self->{p}->e_n_e_t__n_e_t__t_o__h_o_s_t_32($command->{verify_connect}->{outgoing_bandwidth});
	$self->enet_protocol_notify_connect($host, $peer, $event_);
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_notify_connect($host, $peer, $event_)>

=cut

sub enet_protocol_notify_connect($$$$) {
	my ($self, $host, $peer, $event_) = @_;
	$host->{recalculate_bandwidth_limits} = 1;
	if (defined($event_)) {
		$self->enet_protocol_change_state($host, $peer, 5);
		$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T();
		$event_->{peer} = $peer;
		$event_->{data} = $peer->{event_data};
	}
	else {
		$self->enet_protocol_dispatch_state($host, $peer, $peer->{state} == 1 ? 4 : 3);
	}
}

=head2 C<$enet-E<gt>enet_protocol_notify_disconnect($host, $peer, $event_)>

=cut

sub enet_protocol_notify_disconnect($$$$) {
	my ($self, $host, $peer, $event_) = @_;
	if ($peer->{state} >= 3) {
		$host->{recalculate_bandwidth_limits} = 1;
	}
	if ($peer->{state} != 1 && $peer->{state} < 4) {
		$self->enet_peer_reset($peer);
	}
	elsif (defined($event_)) {
		$event_->{type} = ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T();
		$event_->{peer} = $peer;
		$event_->{data} = 0;
		$self->enet_peer_reset($peer);
	}
	else {
		$peer->{event_data} = 0;
		$self->enet_protocol_dispatch_state($host, $peer, 9);
	}
}

=head2 C<$enet-E<gt>enet_protocol_receive_incoming_commands($host, $event_)>

=cut

sub enet_protocol_receive_incoming_commands($$$) {
	my ($self, $host, $event_) = @_;
	for (;;) {
		my $receivedLength;
		my $buffer = ENetBuffer->new();
		$buffer->{data} = $host->{packet_data}->[0];
		$buffer->{data_length} = 4096;
		my $buffers = [];
		$buffers->[0] = $buffer;
		$receivedLength = $self->{p}->enet_socket_receive($host->{socket}, $host->{received_address}, $buffers, 1);
		if ($receivedLength < 0) {
			return -1;
		}
		if ($receivedLength == 0) {
			return 0;
		}
		$host->{received_data} = $host->{packet_data}->[0];
		$host->{received_data_length} = $receivedLength;
		$host->{total_received_data} += $receivedLength;
		$host->{total_received_packets}++;
		if (defined($host->{intercept})) {
			given ($host->{intercept}->run($host, $event_)) {
				when (1) {
					if (defined($event_) && $event_->{type} != ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E()) {
						return 1;
					}
					next;
				}
				when (-1) {
					return -1;
				}
			}
		}
		given ($self->enet_protocol_handle_incoming_commands($host, $event_)) {
			when (1) {
				return 1;
			}
			when (-1) {
				return -1;
			}
		}
	}
}

=head2 C<$enet-E<gt>enet_protocol_remove_sent_reliable_command($peer, $reliableSequenceNumber, $channelID)>

=cut

sub enet_protocol_remove_sent_reliable_command($$$$) {
	my ($self, $peer, $reliableSequenceNumber, $channelID) = @_;
	my $outgoingCommand = undef;
	my $currentCommand;
	my $commandNumber;
	my $wasSent = 1;
	for ($currentCommand = $self->enet_list_begin($peer->{sent_reliable_commands}); $currentCommand != $self->enet_list_end($peer->{sent_reliable_commands}); $currentCommand = $self->enet_list_next($currentCommand)) {
		$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($currentCommand);
		if ($outgoingCommand->{reliable_sequence_number} == $reliableSequenceNumber && $outgoingCommand->{command}->{header}->{channel_i_d} == $channelID) {
			last;
		}
	}
	if ($currentCommand == $self->enet_list_end($peer->{sent_reliable_commands})) {
		for ($currentCommand = $self->enet_list_begin($peer->{outgoing_reliable_commands}); $currentCommand != $self->enet_list_end($peer->{outgoing_reliable_commands}); $currentCommand = $self->enet_list_next($currentCommand)) {
			$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($currentCommand);
			if ($outgoingCommand->{send_attempts} < 1) {
				return 0;
			}
			if ($outgoingCommand->{reliable_sequence_number} == $reliableSequenceNumber && $outgoingCommand->{command}->{header}->{channel_i_d} == $channelID) {
				last;
			}
		}
		if ($currentCommand == $self->enet_list_end($peer->{outgoing_reliable_commands})) {
			return 0;
		}
		$wasSent = 0;
	}
	if (!defined($outgoingCommand)) {
		return 0;
	}
	if ($channelID < $peer->{channel_count}) {
		my $channel = $peer->{channels}->[$channelID];
		my $reliableWindow = $self->{p}->int_to_ushort($reliableSequenceNumber / 4096);
		if ($channel->{reliable_windows}->[$reliableWindow] > 0) {
			$channel->{reliable_windows}->[$reliableWindow]--;
			if ($channel->{reliable_windows}->[$reliableWindow] == 0) {
				$channel->{used_reliable_windows} &= ~(1 << $reliableWindow);
			}
		}
	}
	$commandNumber = $outgoingCommand->{command}->{header}->{command} & 15;
	$self->enet_list_remove($outgoingCommand->outgoing_command_list());
	if (defined($outgoingCommand->{packet})) {
		if ($wasSent != 0) {
			$peer->{reliable_data_in_transit} -= $outgoingCommand->{fragment_length};
		}
		$outgoingCommand->{packet}->{reference_count}--;
		if ($outgoingCommand->{packet}->{reference_count} == 0) {
			$outgoingCommand->{packet}->{flags} |= 256;
			$self->enet_packet_destroy($outgoingCommand->{packet});
		}
	}
	if ($self->enet_list_empty($peer->{sent_reliable_commands})) {
		return $commandNumber;
	}
	$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($self->enet_list_front($peer->{sent_reliable_commands}));
	$peer->{next_timeout} = $outgoingCommand->{sent_time} + $outgoingCommand->{round_trip_timeout};
	return $commandNumber;
}

=head2 C<$enet-E<gt>enet_protocol_remove_sent_unreliable_commands($peer)>

=cut

sub enet_protocol_remove_sent_unreliable_commands($$) {
	my ($self, $peer) = @_;
	my $outgoingCommand;
	while (!$self->enet_list_empty($peer->{sent_unreliable_commands})) {
		$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($self->enet_list_front($peer->{sent_unreliable_commands}));
		$self->enet_list_remove($outgoingCommand->outgoing_command_list());
		if (defined($outgoingCommand->{packet})) {
			$outgoingCommand->{packet}->{reference_count}--;
			if ($outgoingCommand->{packet}->{reference_count} == 0) {
				$outgoingCommand->{packet}->{flags} |= 256;
				$self->enet_packet_destroy($outgoingCommand->{packet});
			}
		}
	}
}

sub enet_protocol_send_acknowledgements($$$) {
	my ($self, $host, $peer) = @_;
	my $commandI = $host->{command_count};
	my $bufferI = $host->{buffer_count};
	my $acknowledgement;
	my $currentAcknowledgement;
	my $reliableSequenceNumber;
	$currentAcknowledgement = $self->enet_list_begin($peer->{acknowledgements});
	while ($currentAcknowledgement != $self->enet_list_end($peer->{acknowledgements})) {
		if ($commandI >= 32 || $bufferI >= 65 || $peer->{mtu} - $host->{packet_size} < 8) {
			$host->{continue_sending} = 1;
			last;
		}
		$acknowledgement = $self->{p}->cast_to_e_net_acknowledgement($currentAcknowledgement);
		$currentAcknowledgement = $self->enet_list_next($currentAcknowledgement);
		if ($self->{test1} == 1) {
		}
		$reliableSequenceNumber = $self->e_n_e_t__h_o_s_t__t_o__n_e_t_16($acknowledgement->{command}->{header}->{reliable_sequence_number});
		$host->{commands}->[$commandI]->{header}->{command} = 1;
		$host->{commands}->[$commandI]->{header}->{channel_i_d} = $acknowledgement->{command}->{header}->{channel_i_d};
		$host->{commands}->[$commandI]->{header}->{reliable_sequence_number} = $reliableSequenceNumber;
		$host->{commands}->[$commandI]->{acknowledge} = ENetProtocolAcknowledge->new();
		$host->{commands}->[$commandI]->{acknowledge}->{received_reliable_sequence_number} = $reliableSequenceNumber;
		$host->{commands}->[$commandI]->{acknowledge}->{received_sent_time} = $self->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($acknowledgement->{sent_time}));
		my $buf = [];
		$self->serialize_command($buf, $host->{commands}->[$commandI]);
		$host->{buffers}->[$bufferI]->{data} = $buf;
		$host->{buffers}->[$bufferI]->{data_length} = 8;
		$host->{packet_size} += $host->{buffers}->[$bufferI]->{data_length};
		if (($acknowledgement->{command}->{header}->{command} & 15) == 4) {
			$self->enet_protocol_dispatch_state($host, $peer, 9);
		}
		$self->enet_list_remove($acknowledgement->acknowledgement_list());
		$commandI++;
		$bufferI++;
	}
	$host->{command_count} = $commandI;
	$host->{buffer_count} = $bufferI;
}

=head2 C<$enet-E<gt>enet_protocol_send_outgoing_commands($host, $event_, $checkForTimeouts)>

=cut

sub enet_protocol_send_outgoing_commands($$$$) {
	my ($self, $host, $event_, $checkForTimeouts) = @_;
	my $headerData = [];
	my $header = ENetProtocolHeader->new();
	my $currentPeer;
	my $sentLength;
	my $shouldCompress = 0;
	$host->{continue_sending} = 1;
	while ($host->{continue_sending} != 0) {
		$host->{continue_sending} = 0;
		for (my $i = 0; $i < $host->{peer_count}; $i++) {
			if ($self->{test1} == 1) {
			}
			$currentPeer = $host->{peers}->[$i];
			if ($currentPeer->{state} == 0 || $currentPeer->{state} == 9) {
				next;
			}
			$host->{header_flags} = 0;
			$host->{command_count} = 0;
			$host->{buffer_count} = 1;
			$host->{packet_size} = 4;
			if (!$self->enet_list_empty($currentPeer->{acknowledgements})) {
				$self->enet_protocol_send_acknowledgements($host, $currentPeer);
			}
			if ($checkForTimeouts != 0 && !$self->enet_list_empty($currentPeer->{sent_reliable_commands}) && $self->e_n_e_t__t_i_m_e__g_r_e_a_t_e_r__e_q_u_a_l($host->{service_time}, $currentPeer->{next_timeout}) && $self->enet_protocol_check_timeouts($host, $currentPeer, $event_) == 1) {
				if (defined($event_) && $event_->{type} != ENetEventType::E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E()) {
					return 1;
				}
				else {
					next;
				}
			}
			if (($self->enet_list_empty($currentPeer->{outgoing_reliable_commands}) || $self->enet_protocol_send_reliable_outgoing_commands($host, $currentPeer) != 0) && $self->enet_list_empty($currentPeer->{sent_reliable_commands}) && $self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $currentPeer->{last_receive_time}) >= $currentPeer->{ping_interval} && $currentPeer->{mtu} - $host->{packet_size} >= 4) {
				$self->enet_peer_ping($currentPeer);
				$self->enet_protocol_send_reliable_outgoing_commands($host, $currentPeer);
			}
			if (!$self->enet_list_empty($currentPeer->{outgoing_unreliable_commands})) {
				$self->enet_protocol_send_unreliable_outgoing_commands($host, $currentPeer);
			}
			if ($host->{command_count} == 0) {
				next;
			}
			if ($currentPeer->{packet_loss_epoch} == 0) {
				$currentPeer->{packet_loss_epoch} = $host->{service_time};
			}
			elsif ($self->e_n_e_t__t_i_m_e__d_i_f_f_e_r_e_n_c_e($host->{service_time}, $currentPeer->{packet_loss_epoch}) >= 10000 && $currentPeer->{packets_sent} > 0) {
				my $packetLoss = $currentPeer->{packets_lost} * 65536 / $currentPeer->{packets_sent};
				$currentPeer->{packet_loss_variance} -= $currentPeer->{packet_loss_variance} / 4;
				if ($packetLoss >= $currentPeer->{packet_loss}) {
					$currentPeer->{packet_loss} += ($packetLoss - $currentPeer->{packet_loss}) / 8;
					$currentPeer->{packet_loss_variance} += ($packetLoss - $currentPeer->{packet_loss}) / 4;
				}
				else {
					$currentPeer->{packet_loss} -= ($currentPeer->{packet_loss} - $packetLoss) / 8;
					$currentPeer->{packet_loss_variance} += ($currentPeer->{packet_loss} - $packetLoss) / 4;
				}
				$currentPeer->{packet_loss_epoch} = $host->{service_time};
				$currentPeer->{packets_sent} = 0;
				$currentPeer->{packets_lost} = 0;
			}
			$host->{buffers}->[0]->{data} = $headerData;
			if (($host->{header_flags} & 32768) != 0) {
				$header->{sent_time} = $self->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($host->{service_time} & 65535));
				$host->{buffers}->[0]->{data_length} = 4;
			}
			else {
				$host->{buffers}->[0]->{data_length} = 2;
			}
			$shouldCompress = 0;
			if (defined($host->{compressor})) {
			}
			if ($currentPeer->{outgoing_peer_i_d} < 4095) {
				$host->{header_flags} |= $self->{p}->int_to_ushort($currentPeer->{outgoing_session_i_d} << 12);
			}
			$header->{peer_i_d} = $self->e_n_e_t__h_o_s_t__t_o__n_e_t_16($self->{p}->int_to_ushort($currentPeer->{outgoing_peer_i_d} | $host->{header_flags}));
			$self->serialize_header($headerData, $header);
			if (defined($host->{checksum})) {
			}
			if ($shouldCompress > 0) {
				$host->{buffers}->[1]->{data} = $host->{packet_data}->[1];
				$host->{buffers}->[1]->{data_length} = $shouldCompress;
				$host->{buffer_count} = 2;
			}
			$currentPeer->{last_send_time} = $host->{service_time};
			$sentLength = $self->{p}->enet_socket_send($host->{socket}, $currentPeer->{address}, $host->{buffers}, $host->{buffer_count});
			$self->enet_protocol_remove_sent_unreliable_commands($currentPeer);
			if ($sentLength < 0) {
				return -1;
			}
			$host->{total_sent_data} += $sentLength;
			$host->{total_sent_packets}++;
		}
	}
	return 0;
}

=head2 C<$enet-E<gt>enet_protocol_send_reliable_outgoing_commands($host, $peer)>

=cut

sub enet_protocol_send_reliable_outgoing_commands($$$) {
	my ($self, $host, $peer) = @_;
	my $commandI = $host->{command_count};
	my $bufferI = $host->{buffer_count};
	my $outgoingCommand;
	my $currentCommand;
	my $channel;
	my $reliableWindow;
	my $commandSize;
	my $windowExceeded = 0;
	my $windowWrap = 0;
	my $canPing = 1;
	$currentCommand = $self->enet_list_begin($peer->{outgoing_reliable_commands});
	if ($self->{test1} == 1) {
		$self->{test1} = $self->{test1};
	}
	while ($currentCommand != $self->enet_list_end($peer->{outgoing_reliable_commands})) {
		$outgoingCommand = $self->{p}->cast_to_e_net_outgoing_command($currentCommand);
		$channel = $outgoingCommand->{command}->{header}->{channel_i_d} < $peer->{channel_count} ? $peer->{channels}->[$outgoingCommand->{command}->{header}->{channel_i_d}] : undef;
		$reliableWindow = $self->{p}->int_to_ushort($outgoingCommand->{reliable_sequence_number} / 4096);
		if (defined($channel)) {
			if ($windowWrap == 0 && $outgoingCommand->{send_attempts} < 1 && $outgoingCommand->{reliable_sequence_number} % 4096 == 0 && ($channel->{reliable_windows}->[($reliableWindow + 16 - 1) % 16] >= 4096 || ($channel->{used_reliable_windows} & (255 << $reliableWindow | 255 >> 4096 - $reliableWindow)) != 0)) {
				$windowWrap = 1;
			}
			if ($windowWrap != 0) {
				$currentCommand = $self->enet_list_next($currentCommand);
				next;
			}
		}
		if (defined($outgoingCommand->{packet})) {
			if ($windowExceeded == 0) {
				my $windowSize = $peer->{packet_throttle} * $peer->{window_size} / 32;
				if ($peer->{reliable_data_in_transit} + $outgoingCommand->{fragment_length} > $self->e_n_e_t__m_a_x($windowSize, $peer->{mtu})) {
					$windowExceeded = 1;
				}
			}
			if ($windowExceeded != 0) {
				$currentCommand = $self->enet_list_next($currentCommand);
				next;
			}
		}
		$canPing = 0;
		$commandSize = $self->{command_sizes}->[$outgoingCommand->{command}->{header}->{command} & 15];
		if ($commandI > $host->{command_count} || $bufferI > $host->{buffer_count} || $peer->{mtu} - $host->{packet_size} < $commandSize || defined($outgoingCommand->{packet}) && $self->to_uint16($peer->{mtu} - $host->{packet_size}) < $self->to_uint16($commandSize + $outgoingCommand->{fragment_length})) {
			$host->{continue_sending} = 1;
			last;
		}
		$currentCommand = $self->enet_list_next($currentCommand);
		if (defined($channel) && $outgoingCommand->{send_attempts} < 1) {
			$channel->{used_reliable_windows} |= 1 << $reliableWindow;
			$channel->{reliable_windows}->[$reliableWindow]++;
		}
		$outgoingCommand->{send_attempts}++;
		if ($outgoingCommand->{round_trip_timeout} == 0) {
			$outgoingCommand->{round_trip_timeout} = $peer->{round_trip_time} + 4 * $peer->{round_trip_time_variance};
			$outgoingCommand->{round_trip_timeout_limit} = $peer->{timeout_limit} * $outgoingCommand->{round_trip_timeout};
		}
		if ($self->enet_list_empty($peer->{sent_reliable_commands})) {
			$peer->{next_timeout} = $host->{service_time} + $outgoingCommand->{round_trip_timeout};
		}
		$self->enet_list_insert($self->enet_list_end($peer->{sent_reliable_commands}), $self->enet_list_remove($outgoingCommand->outgoing_command_list()));
		$outgoingCommand->{sent_time} = $host->{service_time};
		my $command = $outgoingCommand->{command};
		$host->{commands}->[$commandI] = $command;
		$host->{buffers}->[$bufferI]->{data} = [];
		$self->serialize_command($host->{buffers}->[$bufferI]->{data}, $host->{commands}->[$commandI]);
		$host->{buffers}->[$bufferI]->{data_length} = $commandSize;
		$host->{packet_size} += $host->{buffers}->[$bufferI]->{data_length};
		$host->{header_flags} |= 32768;
		if (defined($outgoingCommand->{packet})) {
			$bufferI++;
			my $data = [];
			for (my $i = 0; $i < $outgoingCommand->{packet}->{data_length} - $outgoingCommand->{fragment_offset}; $i++) {
				$data->[$i] = $outgoingCommand->{packet}->{data}->[$i + $outgoingCommand->{fragment_offset}];
			}
			$host->{buffers}->[$bufferI]->{data} = $data;
			$host->{buffers}->[$bufferI]->{data_length} = $outgoingCommand->{fragment_length};
			$host->{packet_size} += $outgoingCommand->{fragment_length};
			$peer->{reliable_data_in_transit} += $outgoingCommand->{fragment_length};
		}
		$peer->{packets_sent}++;
		$commandI++;
		$bufferI++;
	}
	$host->{command_count} = $commandI;
	$host->{buffer_count} = $bufferI;
	return $canPing;
}

=head2 C<$enet-E<gt>enet_protocol_send_unreliable_outgoing_commands($host, $peer)>

=cut

sub enet_protocol_send_unreliable_outgoing_commands($$$) {
	my ($self, $host, $peer) = @_;
}

sub free_packet($$$) {
	my ($self, $fragmentCount, $packet) = @_;
	if ($fragmentCount > 0) {
		return $self->notify_error($packet);
	}
	if (defined($packet) && $packet->{reference_count} == 0) {
		$self->enet_packet_destroy($packet);
	}
	return $self->{dummy_command};
}

sub initialize_crc32($) {
	my ($self) = @_;
	$self->{crc_table} = [];
	my $byte_;
	my $c = -2147483647;
	$c -= 1;
	for ($byte_ = 0; $byte_ < 256; $byte_++) {
		my $crc = ENet::reflect_crc($byte_, 8) << 24;
		my $offset;
		for ($offset = 0; $offset < 8; $offset++) {
			if (($crc & $c) != 0) {
				$crc = $crc << 1 ^ 79764919;
			}
			else {
				$crc <<= 1;
			}
		}
		$self->{crc_table}->[$byte_] = ENet::reflect_crc($crc, 32);
	}
	$self->{initialized_c_r_c32} = 1;
}

sub memcpy($$$$) {
	my ($self, $destination, $source, $num) = @_;
	for (my $i = 0; $i < $num; $i++) {
		$destination->[$i] = $source->[$i];
	}
}

sub notify_error($$) {
	my ($self, $packet) = @_;
	if (defined($packet) && $packet->{reference_count} == 0) {
		$self->enet_packet_destroy($packet);
	}
	return undef;
}

sub reflect_crc($$) {
	my ($val, $bits) = @_;
	my $result = 0;
	my $bit;
	for ($bit = 0; $bit < $bits; $bit++) {
		if (($val & 1) != 0) {
			$result |= 1 << $bits - 1 - $bit;
		}
		$val >>= 1;
	}
	return $result;
}

=head1 Class ENetAcknowledgement

=cut

package ENetAcknowledgement;

our @ISA = 'ENetListNode';
=head2 C<$enetacknowledgement = ENetAcknowledgement-E<gt>new()>

=cut

=head2 C<$enetacknowledgement-E<gt>acknowledgement_list()>

=cut

sub acknowledgement_list($) {
	my ($self) = @_;
	return $self;
}

=head1 Class ENetAddress

=cut

package ENetAddress;

=head2 C<$enetaddress = ENetAddress-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<ENetAddress::clone($address)>

=cut

sub clone($) {
	my ($address) = @_;
	my $other = ENetAddress->new();
	$other->{host} = $address->{host};
	$other->{port} = $address->{port};
	return $other;
}

=head1 Class ENetBuffer

=cut

package ENetBuffer;

=head2 C<$enetbuffer = ENetBuffer-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetChannel

=cut

package ENetChannel;

=head2 C<ENetChannel::RELIABLE_WINDOWS_LENGTH()>

=cut

sub RELIABLE_WINDOWS_LENGTH() { 16 }

=head2 C<$enetchannel = ENetChannel-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	$self->{reliable_windows} = [];
	$self->{incoming_reliable_commands} = ENetList->new();
	$self->{incoming_unreliable_commands} = ENetList->new();
	return $self;
}

=head1 Class ENetChecksumCallback

=cut

package ENetChecksumCallback;

=head2 C<$enetchecksumcallback = ENetChecksumCallback-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetchecksumcallback-E<gt>run($buffers, $bufferCount)>

=cut

=head1 Class ENetCompressor

An ENet packet compressor for compressing UDP packets before socket sends or receives.

=cut

package ENetCompressor;

=head2 C<$enetcompressor = ENetCompressor-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetcompressor-E<gt>compress($inBuffers, $inBufferCount, $inLimit, \@outData, $outLimit)>

Compresses from inBuffers[0:inBufferCount-1], containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.

=cut

=head2 C<$enetcompressor-E<gt>decompress(\@inData, $inLimit, \@outData, $outLimit)>

Decompresses from inData, containing inLimit bytes, to outData, outputting at most outLimit bytes. Should return 0 on failure.

=cut

=head2 C<$enetcompressor-E<gt>destroy()>

Destroys the context when compression is disabled or the host is destroyed. May be NULL.

=cut

=head1 Class ENetCompressorContext

=cut

package ENetCompressorContext;

=head2 C<$enetcompressorcontext = ENetCompressorContext-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetEvent

=cut

package ENetEvent;

=head2 C<$enetevent = ENetEvent-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetHost

=cut

package ENetHost;

=head2 C<ENetHost::BUFFERS_MAX_COUNT()>

=cut

sub BUFFERS_MAX_COUNT() { 65 }

=head2 C<ENetHost::COMMANDS_MAX_COUNT()>

=cut

sub COMMANDS_MAX_COUNT() { 32 }

=head2 C<ENetHost::PACKET_DATA0_SIZE_OF()>

=cut

sub PACKET_DATA0_SIZE_OF() { 4096 }

=head2 C<$enethost = ENetHost-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	$self->{address} = ENetAddress->new();
	$self->{commands} = [];
	for (my $i = 0; $i < 32; $i++) {
		$self->{commands}->[$i] = ENetProtocol->new();
	}
	$self->{buffers} = [];
	for (my $i = 0; $i < 65; $i++) {
		$self->{buffers}->[$i] = ENetBuffer->new();
	}
	for (my $i = 0; $i < 65; $i++) {
		$self->{buffers}->[$i] = ENetBuffer->new();
	}
	$self->{dispatch_queue} = ENetPeer->new();
	$self->{packet_data} = [];
	$self->{packet_data}->[0] = [];
	$self->{packet_data}->[1] = [];
	return $self;
}

=head1 Class ENetIncomingCommand

=cut

package ENetIncomingCommand;

our @ISA = 'ENetListNode';
=head2 C<$enetincomingcommand = ENetIncomingCommand-E<gt>new()>

=cut

=head2 C<$enetincomingcommand-E<gt>incoming_command_list()>

=cut

sub incoming_command_list($) {
	my ($self) = @_;
	return $self;
}

=head1 Class ENetInterceptCallback

=cut

package ENetInterceptCallback;

=head2 C<$enetinterceptcallback = ENetInterceptCallback-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetinterceptcallback-E<gt>run($host, $event_)>

=cut

=head1 Class ENetList

=cut

package ENetList;

our @ISA = 'ENetListNode';
=head2 C<$enetlist = ENetList-E<gt>new()>

=cut

sub new($) {
	my $self = shift()->SUPER::new();
	$self->set_sentinel(ENetListNode->new());
	return $self;
}

=head2 C<$enetlist-E<gt>get_sentinel()>

=cut

sub get_sentinel($) {
	my ($self) = @_;
	return $self->{next};
}

=head2 C<$enetlist-E<gt>set_sentinel($value)>

=cut

sub set_sentinel($$) {
	my ($self, $value) = @_;
	$self->{next} = $value;
}

=head1 Class ENetListNode

=cut

package ENetListNode;

our @ISA = 'ENetObject';
=head2 C<$enetlistnode = ENetListNode-E<gt>new()>

=cut

=head1 Class ENetObject

=cut

package ENetObject;

=head2 C<$enetobject = ENetObject-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetOutgoingCommand

=cut

package ENetOutgoingCommand;

our @ISA = 'ENetListNode';
=head2 C<$enetoutgoingcommand = ENetOutgoingCommand-E<gt>new()>

=cut

=head2 C<$enetoutgoingcommand-E<gt>outgoing_command_list()>

=cut

sub outgoing_command_list($) {
	my ($self) = @_;
	return $self;
}

=head1 Class ENetPacket

=cut

package ENetPacket;

=head2 C<$enetpacket = ENetPacket-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetpacket-E<gt>get_data()>

=cut

sub get_data($) {
	my ($self) = @_;
	return $self->{data};
}

=head2 C<$enetpacket-E<gt>get_data_length()>

=cut

sub get_data_length($) {
	my ($self) = @_;
	return $self->{data_length};
}

=head2 C<$enetpacket-E<gt>get_flags()>

=cut

sub get_flags($) {
	my ($self) = @_;
	return $self->{flags};
}

=head2 C<$enetpacket-E<gt>get_free_callback()>

=cut

sub get_free_callback($) {
	my ($self) = @_;
	return $self->{free_callback};
}

=head2 C<$enetpacket-E<gt>get_reference_count()>

=cut

sub get_reference_count($) {
	my ($self) = @_;
	return $self->{reference_count};
}

=head2 C<$enetpacket-E<gt>get_user_data()>

=cut

sub get_user_data($) {
	my ($self) = @_;
	return $self->{user_data};
}

=head2 C<$enetpacket-E<gt>set_data(\@value)>

=cut

sub set_data($$) {
	my ($self, $value) = @_;
	$self->{data} = $value;
}

=head2 C<$enetpacket-E<gt>set_data_length($value)>

=cut

sub set_data_length($$) {
	my ($self, $value) = @_;
	$self->{data_length} = $value;
}

=head2 C<$enetpacket-E<gt>set_flags($value)>

=cut

sub set_flags($$) {
	my ($self, $value) = @_;
	$self->{flags} = $value;
}

=head2 C<$enetpacket-E<gt>set_free_callback($value)>

=cut

sub set_free_callback($$) {
	my ($self, $value) = @_;
	$self->{free_callback} = $value;
}

=head2 C<$enetpacket-E<gt>set_reference_count($value)>

=cut

sub set_reference_count($$) {
	my ($self, $value) = @_;
	$self->{reference_count} = $value;
}

=head2 C<$enetpacket-E<gt>set_user_data($value)>

=cut

sub set_user_data($$) {
	my ($self, $value) = @_;
	$self->{user_data} = $value;
}

=head1 Class ENetPacketFlagEnum

=cut

package ENetPacketFlagEnum;

=head2 C<ENetPacketFlagEnum::E_N_E_T__P_A_C_K_E_T__F_L_A_G__N_O__A_L_L_O_C_A_T_E()>

=cut

sub E_N_E_T__P_A_C_K_E_T__F_L_A_G__N_O__A_L_L_O_C_A_T_E() { 4 }

=head2 C<ENetPacketFlagEnum::E_N_E_T__P_A_C_K_E_T__F_L_A_G__R_E_L_I_A_B_L_E()>

=cut

sub E_N_E_T__P_A_C_K_E_T__F_L_A_G__R_E_L_I_A_B_L_E() { 1 }

=head2 C<ENetPacketFlagEnum::E_N_E_T__P_A_C_K_E_T__F_L_A_G__S_E_N_T()>

=cut

sub E_N_E_T__P_A_C_K_E_T__F_L_A_G__S_E_N_T() { 256 }

=head2 C<ENetPacketFlagEnum::E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T()>

=cut

sub E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T() { 8 }

=head2 C<ENetPacketFlagEnum::E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D()>

=cut

sub E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D() { 2 }

=head2 C<$enetpacketflagenum = ENetPacketFlagEnum-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetPacketFreeCallback

=cut

package ENetPacketFreeCallback;

=head2 C<$enetpacketfreecallback = ENetPacketFreeCallback-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetpacketfreecallback-E<gt>run($packet)>

=cut

=head1 Class ENetPeer

=cut

package ENetPeer;

our @ISA = 'ENetList';
=head2 C<ENetPeer::UNSEQUENCED_WINDOW_LENGTH()>

=cut

sub UNSEQUENCED_WINDOW_LENGTH() { 32 }

=head2 C<$enetpeer = ENetPeer-E<gt>new()>

=cut

sub new($) {
	my $self = shift()->SUPER::new();
	$self->{acknowledgements} = ENetList->new();
	$self->{sent_reliable_commands} = ENetList->new();
	$self->{sent_unreliable_commands} = ENetList->new();
	$self->{outgoing_reliable_commands} = ENetList->new();
	$self->{outgoing_unreliable_commands} = ENetList->new();
	$self->{dispatched_commands} = ENetList->new();
	$self->{unsequenced_window} = [];
	return $self;
}

sub dispatch_list($) {
	my ($self) = @_;
	return $self;
}

=head1 Class ENetPeerState

=cut

package ENetPeerState;

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__C_O_N_N_E_C_T()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__C_O_N_N_E_C_T() { 2 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__D_I_S_C_O_N_N_E_C_T()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__D_I_S_C_O_N_N_E_C_T() { 8 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_E_D()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_E_D() { 5 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_N_G()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_N_G() { 1 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__P_E_N_D_I_N_G()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__P_E_N_D_I_N_G() { 3 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__S_U_C_C_E_E_D_E_D()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__S_U_C_C_E_E_D_E_D() { 4 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_E_D()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_E_D() { 0 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_I_N_G()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_I_N_G() { 7 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T__L_A_T_E_R()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T__L_A_T_E_R() { 6 }

=head2 C<ENetPeerState::E_N_E_T__P_E_E_R__S_T_A_T_E__Z_O_M_B_I_E()>

=cut

sub E_N_E_T__P_E_E_R__S_T_A_T_E__Z_O_M_B_I_E() { 9 }

=head2 C<$enetpeerstate = ENetPeerState-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetPlatform

=cut

package ENetPlatform;

=head2 C<$enetplatform = ENetPlatform-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetplatform-E<gt>cast_to_e_net_acknowledgement($a)>

=cut

=head2 C<$enetplatform-E<gt>cast_to_e_net_incoming_command($a)>

=cut

=head2 C<$enetplatform-E<gt>cast_to_e_net_list_node($a)>

=cut

=head2 C<$enetplatform-E<gt>cast_to_e_net_outgoing_command($a)>

=cut

=head2 C<$enetplatform-E<gt>cast_to_e_net_peer($a)>

=cut

=head2 C<$enetplatform-E<gt>e_n_e_t__h_o_s_t__t_o__n_e_t_16($p)>

=cut

=head2 C<$enetplatform-E<gt>e_n_e_t__h_o_s_t__t_o__n_e_t_32($p)>

=cut

=head2 C<$enetplatform-E<gt>e_n_e_t__n_e_t__t_o__h_o_s_t_16($p)>

=cut

=head2 C<$enetplatform-E<gt>e_n_e_t__n_e_t__t_o__h_o_s_t_32($fragmentOffset)>

=cut

=head2 C<$enetplatform-E<gt>int_to_ushort($p)>

=cut

=head2 C<$enetplatform-E<gt>enet_address_set_host($address, $hostName)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_accept($socket, $address)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_bind($socket, $address)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_connect($socket, $address)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_create($type)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_destroy($socket)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_get_address($socket, $address)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_listen($socket, $backlog)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_receive($socket, $address, \@buffers, $bufferCount)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_send($socket, $address, \@buffers, $bufferCount)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_set_option($socket, $option, $value)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_shutdown($socket, $how)>

=cut

=head2 C<$enetplatform-E<gt>enet_socket_wait($socket, \@condition, $timeout)>

=cut

=head2 C<$enetplatform-E<gt>enet_time_get()>

=cut

=head2 C<$enetplatform-E<gt>time()>

=cut

=head1 Class ENetProtocol

=cut

package ENetProtocol;

=head2 C<$enetprotocol = ENetProtocol-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	$self->{header} = ENetProtocolCommandHeader->new();
	return $self;
}

=head1 Class ENetProtocolAcknowledge

=cut

package ENetProtocolAcknowledge;

=head2 C<ENetProtocolAcknowledge::SIZE_OF()>

=cut

sub SIZE_OF() { 8 }

=head2 C<$enetprotocolacknowledge = ENetProtocolAcknowledge-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolBandwidthLimit

=cut

package ENetProtocolBandwidthLimit;

=head2 C<$enetprotocolbandwidthlimit = ENetProtocolBandwidthLimit-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolCommandHeader

=cut

package ENetProtocolCommandHeader;

=head2 C<ENetProtocolCommandHeader::SIZE_OF()>

=cut

sub SIZE_OF() { 4 }

=head2 C<$enetprotocolcommandheader = ENetProtocolCommandHeader-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolConnect

=cut

package ENetProtocolConnect;

=head2 C<$enetprotocolconnect = ENetProtocolConnect-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolDisconnect

=cut

package ENetProtocolDisconnect;

=head2 C<$enetprotocoldisconnect = ENetProtocolDisconnect-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolHeader

=cut

package ENetProtocolHeader;

=head2 C<ENetProtocolHeader::SIZE_OF()>

=cut

sub SIZE_OF() { 4 }

=head2 C<$enetprotocolheader = ENetProtocolHeader-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolPing

=cut

package ENetProtocolPing;

=head2 C<ENetProtocolPing::SIZE_OF()>

=cut

sub SIZE_OF() { 4 }

=head2 C<$enetprotocolping = ENetProtocolPing-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolSendFragment

=cut

package ENetProtocolSendFragment;

=head2 C<ENetProtocolSendFragment::SIZE_OF()>

=cut

sub SIZE_OF() { 28 }

=head2 C<$enetprotocolsendfragment = ENetProtocolSendFragment-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolSendReliable

=cut

package ENetProtocolSendReliable;

=head2 C<ENetProtocolSendReliable::SIZE_OF()>

=cut

sub SIZE_OF() { 6 }

=head2 C<$enetprotocolsendreliable = ENetProtocolSendReliable-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolSendUnreliable

=cut

package ENetProtocolSendUnreliable;

=head2 C<ENetProtocolSendUnreliable::SIZE_OF()>

=cut

sub SIZE_OF() { 12 }

=head2 C<$enetprotocolsendunreliable = ENetProtocolSendUnreliable-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolSendUnsequenced

=cut

package ENetProtocolSendUnsequenced;

=head2 C<$enetprotocolsendunsequenced = ENetProtocolSendUnsequenced-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolThrottleConfigure

=cut

package ENetProtocolThrottleConfigure;

=head2 C<$enetprotocolthrottleconfigure = ENetProtocolThrottleConfigure-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetProtocolVerifyConnect

=cut

package ENetProtocolVerifyConnect;

=head2 C<$enetprotocolverifyconnect = ENetProtocolVerifyConnect-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetSocket

=cut

package ENetSocket;

=head2 C<$enetsocket = ENetSocket-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<$enetsocket-E<gt>n_u_l_l()>

=cut

=head1 Class ENetSocketOption

=cut

package ENetSocketOption;

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__B_R_O_A_D_C_A_S_T()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__B_R_O_A_D_C_A_S_T() { 2 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__E_R_R_O_R()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__E_R_R_O_R() { 8 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__N_O_D_E_L_A_Y()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__N_O_D_E_L_A_Y() { 9 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__N_O_N_B_L_O_C_K()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__N_O_N_B_L_O_C_K() { 1 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__R_C_V_B_U_F()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__R_C_V_B_U_F() { 3 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__R_C_V_T_I_M_E_O()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__R_C_V_T_I_M_E_O() { 6 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__R_E_U_S_E_A_D_D_R()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__R_E_U_S_E_A_D_D_R() { 5 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__S_N_D_B_U_F()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__S_N_D_B_U_F() { 4 }

=head2 C<ENetSocketOption::E_N_E_T__S_O_C_K_O_P_T__S_N_D_T_I_M_E_O()>

=cut

sub E_N_E_T__S_O_C_K_O_P_T__S_N_D_T_I_M_E_O() { 7 }

=head2 C<$enetsocketoption = ENetSocketOption-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetSocketShutdown

=cut

package ENetSocketShutdown;

=head2 C<ENetSocketShutdown::E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D()>

=cut

sub E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D() { 0 }

=head2 C<ENetSocketShutdown::E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D__W_R_I_T_E()>

=cut

sub E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D__W_R_I_T_E() { 2 }

=head2 C<ENetSocketShutdown::E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__W_R_I_T_E()>

=cut

sub E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__W_R_I_T_E() { 1 }

=head2 C<$enetsocketshutdown = ENetSocketShutdown-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetSocketTypeEnum

=cut

package ENetSocketTypeEnum;

=head2 C<ENetSocketTypeEnum::E_N_E_T__S_O_C_K_E_T__T_Y_P_E__D_A_T_A_G_R_A_M()>

=cut

sub E_N_E_T__S_O_C_K_E_T__T_Y_P_E__D_A_T_A_G_R_A_M() { 2 }

=head2 C<ENetSocketTypeEnum::E_N_E_T__S_O_C_K_E_T__T_Y_P_E__S_T_R_E_A_M()>

=cut

sub E_N_E_T__S_O_C_K_E_T__T_Y_P_E__S_T_R_E_A_M() { 1 }

=head2 C<$enetsockettypeenum = ENetSocketTypeEnum-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class ENetSymbol

=cut

package ENetSymbol;

=head2 C<$enetsymbol = ENetSymbol-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head1 Class Math

=cut

package Math;

=head2 C<$math = Math-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

=head2 C<Math::is_less_than_unsigned($n1, $n2)>

=cut

sub is_less_than_unsigned($$) {
	my ($n1, $n2) = @_;
	my $comp = $n1 < $n2;
	if ($n1 < 0 != $n2 < 0) {
		$comp = !$comp;
	}
	return $comp;
}

=head1 Class UserData

=cut

package UserData;

=head2 C<$userdata = UserData-E<gt>new()>

=cut

sub new($) {
	my $self = bless {}, shift;
	return $self;
}

1;
